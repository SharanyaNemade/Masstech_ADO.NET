using System;
using System.Data.SqlClient;

class EmpRepo : IEmpRepo
{
    SqlConnection conn;

    public EmpRepo()
    {
        conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=febbatch2026;Integrated Security=True;" +
            "Encrypt=False;MultipleActiveResultSets=True");

        conn.Open();
    }

    public void AddEmp()
    {
        string name;
        double salary;

        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter Salary:");
        salary = double.Parse(Console.ReadLine());

        string q = $"exec sp_SaveEmp '{name}', '{salary}' ";
        SqlCommand cmd = new SqlCommand(q, conn);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Emp Added Success");
    }



public void FetchEmp()
{
    string q = "exec sp_fetchEmpList";
    SqlCommand cmd = new SqlCommand(q, conn);
    SqlDataReader rdr = cmd.ExecuteReader();
    if (rdr.HasRows)
    {
        while (rdr.Read())
        {
            int id = int.Parse(rdr["id"].ToString());
            string name = rdr["name"].ToString();
            double sal = double.Parse(rdr["salary"].ToString());
            double pf = double.Parse(rdr["pf"].ToString());
            double netsal = double.Parse(rdr["netsal"].ToString());
            Console.WriteLine($"ID : {id} \nName : {name} \nSalary : {sal}\nPf : {pf}\nNet Salary: {netsal}\n");
        }
    }
    else
    {
        Console.WriteLine("No Data");
    }
   }
}