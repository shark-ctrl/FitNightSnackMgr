using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FitNightSnackMgr.ViewModels.OrdersViewModel;
using FitNightSnackMgr.Tools;
using FitNightSnackMgr.Models;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;





namespace FitNightSnackMgr.Controllers
{
    public class OrdersController : Controller
    {
        private readonly FitNightSnackMgrContext _context;
        public OrdersController(FitNightSnackMgrContext context)
        {
            _context = context;
        }



        // GET: OrdersController
        public async Task<ActionResult> IndexAsync(int? pageNumber,string SearchString)
        {

            PaginatedList<Order> pageOrder = null;
            if (SearchString == null)
            { pageOrder = await PaginatedList<Order>.CreateAsync(_context.Orders.Where(o=>o.Status==0), pageNumber ?? 1, 10); }
            else
            { pageOrder = await PaginatedList<Order>.CreateAsync(_context.Orders.Where(o => o.OrderId==SearchString&&o.Status==0), pageNumber ?? 1, 10); }


            List<OrderDetailModel> orderDetails = new List<OrderDetailModel>();

            foreach (var item in pageOrder)
            {

                OrderDetailModel o = new OrderDetailModel()
                {
                    OrderId = item.OrderId,
                    Discount = item.Discount,
                    OrderDetail = item.OrderDetail,
                    TotalPrice = item.TotalPrice,
                    Status = item.Status,
                    UserName = _context.User.FirstOrDefault(u => u.Id == 26).UserName,
                    Address = _context.User.FirstOrDefault(u => u.Id == 26).Address

                };

                orderDetails.Add(o);

            }

            int total = _context.Orders.Where(o=>o.Status!=1).Count();
            int pagecount = total / 10 + 1;
            if (pagecount > 10) pagecount = 10;


            OrderDetailAndPage orderDetailAndPage = new OrderDetailAndPage()
            {

                OrderDetailModels = orderDetails,
                PageIndex= pageNumber?? 1,
                PageTotal=pagecount

            };
          


            return View(orderDetailAndPage);
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(string id)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.OrderId == id);
            OrderDetailModel orderDetailModel = new OrderDetailModel()
            {
                OrderId=order.OrderId,
                Discount=order.Discount,
                OrderDetail=order.OrderDetail,
                TotalPrice=order.TotalPrice,
                Status = order.Status,
                UserName = _context.User.FirstOrDefault(u=>u.Id==order.UserId).UserName,
                Address = _context.User.FirstOrDefault(u => u.Id == order.UserId).Address
            };
            return View(orderDetailModel);
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            prepaidCard prepaidCard = new prepaidCard()
            {

                CardCode = PassWordHelper.GenerateCheckCode(8),
                SecretKey = PassWordHelper.GenerateCheckCode(8)

            };
            return View(prepaidCard);
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }



        /// <summary>
        /// 注意str 格式必须为 香烟*1 啤酒*2 产品*数量  再接一个空格 继续下一个产品的格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string CreateTicketStr(string str,string username,string address,string phone,double total,DateTime createtime)
        {
            string strtest = str;
            string[] ss = strtest.Split(' ');
            string res = "       FIT深夜食堂              \n";

            foreach (string item in ss)
            {
               
                res += item + "\n";
            }
            res += $"**********************************\n";
            res += $"name     {username}\n";
            res += $"phone:  {phone}\n";
            res += $"address  {address}\n";
            res += $"time    {createtime}\n";
            res += $"total  {total}\n";

            return res;



        }


        public FileStreamResult PdfPrint(string id)
        {

            var order = _context.Orders.FirstOrDefault(o => o.OrderId == id);
            string order_detail = order.OrderDetail;
            string username = _context.User.FirstOrDefault(u => u.Id == order.UserId).UserName;
            string address = _context.User.FirstOrDefault(u => u.Id == order.UserId).Address;
            string phone = _context.User.FirstOrDefault(u => u.Id == order.UserId).Phone;
            double total = order.TotalPrice;
            DateTime createTime = order.CreateTime;



            string ticketStr = CreateTicketStr(order_detail, username, address, phone, total, createTime);









            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page to the document
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;

            //Set the standard font
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);



            //实例化一个CJK font对象
            PdfCjkStandardFont cjkFont = new PdfCjkStandardFont(PdfCjkFontFamily.HeiseiMinchoW3, 12f);


            //string ss = SplitItem("香烟*1 啤酒*2", "张三", "A4-401", "1888888888888", "100","111312132");

            //Draw the text
            graphics.DrawString(ticketStr, cjkFont, PdfBrushes.Black, new PointF(0, 0));

            //Saving the PDF to the MemoryStream
            MemoryStream stream = new MemoryStream();

            document.Save(stream);

            //Set the position as '0'.
            stream.Position = 0;

            //Download the PDF document in the browser
            FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");

            fileStreamResult.FileDownloadName = $"{order.OrderId}.pdf";

            return fileStreamResult;




        }




        [HttpPost]
        public bool FinishOrder(string orderid)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == orderid);
            order.Status = 1;
            _context.Update(order);
            _context.SaveChanges();
            //PrintTicket(order.OrderId);
            return true;
        
        }





      
    }
}
