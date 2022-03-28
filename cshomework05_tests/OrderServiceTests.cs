using Microsoft.VisualStudio.TestTools.UnitTesting;
using cshomework05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshomework05.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService test = new OrderService();

        [TestMethod()]
        public void CreatOrderTest()
        {
            int preNum = test.myList.Count();
            test.CreatOrder(20220320, "地址1", "张三");
            int laterNum = test.myList.Count();
            Assert.AreNotEqual(preNum, laterNum);
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException))]
        public void CreatOrderTest2()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.CreatOrder(20220320, "地址5", "张四");
        }

        [TestMethod()]
        public void addOrderTest()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            int num = test.myList.FindIndex(order => order.OrderNum.Equals(20200320));
            int preNum = test.myList[num].orderItems.Count();
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "充电宝", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
            int laterNum = test.myList[num].orderItems.Count();
            Assert.AreNotEqual(preNum, laterNum);
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException))]
        public void addOrderTest2()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "手机壳", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
        }

        [TestMethod()]
        public void DelOrderTest()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "充电宝", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
            test.CreatOrder(20220321, "地址2", "客户2");
            test.addOrder(20220321, "乒乓球拍", 55, 1);
            test.CreatOrder(20220000, "地址3", "客户3");
            test.addOrder(20220000, "笔记本", 5000, 1);
            test.DelOrder(20220321);
            int num = test.myList.Count;
            Assert.AreEqual(num, 2);
        }

        [TestMethod()]
        public void RenewOrderTest()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "充电宝", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
            test.CreatOrder(20220321, "地址2", "客户2");
            test.addOrder(20220321, "乒乓球拍", 55, 1);
            test.CreatOrder(20220000, "地址3", "客户3");
            test.addOrder(20220000, "笔记本", 5000, 1);
            test.RenewOrder(1, 3, 300);
            Assert.AreEqual(test.myList[0].orderItems[2].Price, 300);
        }

        [TestMethod()]
        public void OutOrderTest()
        {

        }

        [TestMethod()]
        public void FindOrderTest()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "充电宝", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
            test.CreatOrder(20220321, "地址2", "客户2");
            test.addOrder(20220321, "乒乓球拍", 55, 1);
            test.CreatOrder(20220000, "地址3", "客户3");
            test.addOrder(20220000, "笔记本", 5000, 1);
            test.FindOrder();
        }

        [TestMethod()]
        public void ExportTest()
        {
            test.CreatOrder(20220320, "地址1", "张三");
            test.addOrder(20220320, "手机壳", 20, 1);
            test.addOrder(20220320, "充电宝", 100, 1);
            test.addOrder(20220320, "充电线", 30, 2);
            test.CreatOrder(20220321, "地址2", "客户2");
            test.addOrder(20220321, "乒乓球拍", 55, 1);
            test.CreatOrder(20220000, "地址3", "客户3");
            test.addOrder(20220000, "笔记本", 5000, 1);
            test.Export();
            Assert.IsNotNull(System.IO.Path.GetFileName("Orders.txt"));
        }

        [TestMethod()]
        public void ImportTest()
        {
        }
    }
}