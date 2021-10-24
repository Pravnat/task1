using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
			String name;
			String address;
			String mobileno;
			String mailid;
			String qualification;
			String dob;
			Console.WriteLine("Enter your Name :");
			name = Console.ReadLine();
			Console.WriteLine("Enter your Address :");
			address = Console.ReadLine();
			Console.WriteLine("Enter your MobileNo :");
			mobileno = Console.ReadLine();
			Console.WriteLine("Enter your MailId :");
			mailid = Console.ReadLine();
			Console.WriteLine("Enter your Qualification :");
			qualification = Console.ReadLine();
			Console.WriteLine("Enter today Dob :");
			date = Console.ReadLine();
			Console.WriteLine("---------------------------------");
			Console.WriteLine(name);
			Console.WriteLine(address);
			Console.WriteLine(mobileno);
			Console.WriteLine(mailid);
			Console.WriteLine(qualification);
			Console.WriteLine(date);
			Console.Read();
		}
    }
}
