using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public class Order
        {
            string type;
            public void creatOrder()
            {
                Console.WriteLine("1:添加订单\n2:删除订单\n3:修改订单\n4:查询订单\n其他:退出");
                type = Console.ReadLine();
                if (type == "1")
                {
                    addOrder();
                }
                else if (type == "2")
                {
                    deleteOrder();
                }
                else if (type == "3")
                {
                    changeOrder();
                }
                else if (type == "4")
                {
                    searchOrder();
                }
                else
                {
                    Console.WriteLine("已经退出\n");
                }
            }
            public virtual void addOrder()
            {
            }
            public virtual void deleteOrder()
            {
            }
            public virtual void changeOrder()
            {
            }
            public virtual void searchOrder()
            {
            }
        }
        public class OrderDetails : Order
        {
            protected List<String> orderList = new List<String>();
            public void showOrder()
            {
                foreach (String s in orderList)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public class OrderService : OrderDetails
        {
            public override void addOrder()
            {
                string order;
                Console.WriteLine("请输入姓名：");
                order = Console.ReadLine();
                order += "-";
                Console.WriteLine("请输入商品名：");
                order += Console.ReadLine();
                order += "-";
                Console.WriteLine("请输入订单号：");
                order += Console.ReadLine();
                orderList.Add(order);
                Console.WriteLine("已添加成功");
                showOrder();
                creatOrder();
            }
            public override void deleteOrder()
            {
                String orderNum;
                Console.WriteLine("请输入订单号：");
                orderNum = Console.ReadLine();
                foreach (String s in orderList)
                {
                    try
                    {
                        int position = s.LastIndexOf("-");
                        string subString = s.Substring(position + 1, 3);
                        if (subString == orderNum)
                        {
                            orderList.Remove(s);
                            Console.WriteLine("已删除完成");
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("删除失败！");
                    }

                }
                showOrder();
                creatOrder();
            }
            public override void changeOrder()
            {
                String orderNum;
                Console.WriteLine("请输入订单号：");
                orderNum = Console.ReadLine();
                foreach (String s in orderList)
                {
                    try
                    {
                        int position = s.LastIndexOf("-");
                        string subString = s.Substring(position + 1, 3);
                        if (subString == orderNum)
                        {
                            Console.WriteLine("请输入新商品名：");
                            String good = Console.ReadLine();
                            string[] orderArray = s.Split('-');
                            orderArray[1] = good;
                            String newOrder = "";
                            for (int i = 0; i < 3; i++)
                            {
                                newOrder += orderArray[i];
                                if (i < 2)
                                {
                                    newOrder += "-";
                                }
                            }
                            orderList.Remove(s);
                            orderList.Add(newOrder);
                            Console.WriteLine("已修改完成");
                            break;
                        }
                    }
                    catch (ArrayTypeMismatchException e)
                    {
                        Console.WriteLine("修改失败！");
                    }
                }
                showOrder();
                creatOrder();
            }
            public override void searchOrder()
            {
                Console.WriteLine("1:按客户姓名查询\n2:按商品名称查询\n3:按订单号查询\n其他:退出");
                string type = Console.ReadLine();
                foreach (String s in orderList)
                {
                    if (type == "1")
                    {
                        Console.WriteLine("请输入姓名：");
                        String name = Console.ReadLine();
                        string[] orderArray = s.Split('-');
                        var m = from n in orderList where orderArray[0] == name select n;
                        foreach (var a in m)
                        {
                            Console.WriteLine(a);
                        }
                    }
                    else if (type == "2")
                    {
                        Console.WriteLine("请输入商品名：");
                        String good = Console.ReadLine();
                        string[] orderArray = s.Split('-');
                        var m = from n in orderList where orderArray[1] == good select n;
                        foreach (var a in m)
                        {
                            Console.WriteLine(a);
                        }
                    }
                    else if (type == "3")
                    {
                        Console.WriteLine("请输入订单号：");
                        String num = Console.ReadLine();
                        string[] orderArray = s.Split('-');
                        var m = from n in orderList where orderArray[2] == num select n;
                        foreach (var a in m)
                        {
                            Console.WriteLine(a);
                        }
                    }
                    else
                    {
                        Console.WriteLine("已经退出\n");
                    }
                }
                creatOrder();
            }
        }
        static void Main(string[] args)
        {
            OrderService order = new OrderService();
            order.creatOrder();
        }
    }
}
