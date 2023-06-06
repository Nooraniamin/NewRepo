using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
   abstract class supermarket
    {
        
        public virtual void Delete(TextBox a)
        {
            MessageBox.Show("Delete");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, ComboBox ab)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f,ComboBox ab)
        {
            MessageBox.Show("Add");
        }
        public virtual void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f,TextBox g, ComboBox ab)
        {
            MessageBox.Show("Add");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c)
        {
            MessageBox.Show("update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            MessageBox.Show("Update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e)
        {
            MessageBox.Show("Update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, ComboBox ab)
        {
            MessageBox.Show("Update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g)
        {
            MessageBox.Show("Update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, ComboBox ab)
        {
            MessageBox.Show("Update");
        }
        public virtual void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, ComboBox ab)
        {
            MessageBox.Show("Update");
        }
    }
    class category: supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c)
        {
            try
            {
                
                con.Open();
                string query = "insert into Categories values(" + a.Text + ",'" +b.Text + "','" + c.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added SuccessFully");
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from Categories where catId=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category is Successfully Delete");
            con.Close();

        }
        public override void update(TextBox a, TextBox b, TextBox c)
        {
            try
            {
                con.Open();
                string query = "update Categories set catname='" + b.Text + "',catdes='" + c.Text + "'where C=catId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category is Successfully update");
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    class vender: supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            try
            {
                con.Open();
                string query = "insert into Vender values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vender Added SuccessFully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from Vender where VendId=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vender is Successfully Delete");
            con.Close();
        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            try
            {
                con.Open();
                string query = "update Vender set VendName='" + b.Text + "',vandcompanyname='" + c.Text + "',vandphone='" + d.Text + "'where VendId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vender is Successfully update");
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
    class Vendpayment: supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f,TextBox g, ComboBox ab)
        {
            try
            {
                int cash, credit, debit, balance;
                cash = int.Parse(c.Text);
                credit = int.Parse(d.Text);
                debit = int.Parse(e.Text);
                balance = cash + credit - debit;
                f.Text = balance.ToString();
                con.Open();
                string query = "insert into VenderPayment values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + g.Text + "','" + ab.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vender Payment Added SuccessFully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from VenderPayment where billno=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product is Successfully Delete");
            con.Close();
        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, ComboBox ab)
        {
            try
            {
                    int cash, credit, debit, balance;
                    cash = int.Parse(c.Text);
                    credit = int.Parse(d.Text);
                    debit = int.Parse(e.Text);
                    balance = cash + credit - debit;
                    f.Text = balance.ToString();
                    con.Open();
                    string query = "update VenderPayment set quantity='" + b.Text + "', billcash='" + c.Text + "',dredit ='" + d.Text + "',debit='" + e.Text + "',balance='" + f.Text + "', date='" + g.Text + "', name='" + ab.SelectedValue.ToString() + "'where billno=" + ab.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vender Payment is Successfully update");
                    con.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    class seller:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e)
        {
            try
            {
                con.Open();
                string query = "insert into Seller values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added SuccessFully");
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from Seller where SellerId=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee is Successfully Delete");
            con.Close();

        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e)
        {
            try
            {


                con.Open();
                string query = "update Seller set Sellername='" + b.Text + "',SellerAge='" + c.Text + "',SellerPhone='" + d.Text + "',SellerPassword='" + e.Text + "'where SellerId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee is Successfully update");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class empcat:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c)
        {
            try
            {
                //AddCode
                con.Open();
                string query = "insert into employeecat values(" + a.Text + ",'" + b.Text + "','" + c.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Category Added SuccessFully");
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            try
            {
                con.Open();
                string query = "delete from employeecat where empId=" + a.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Category is Successfully Delete");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void update(TextBox a, TextBox b, TextBox c)
        {
            try
            {


                con.Open();
                string query = "update EmployeeCat set empname='" + b.Text + "',empdescription='" + c.Text + "'where empId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Category is Successfully update");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class empdetail:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, ComboBox ab)
        {
            try
            {
                con.Open();
                string query = "insert into employeedetail values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + ab.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added SuccessFully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from employeedetail where empDId=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee is Successfully Delete");
            con.Close();
        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, ComboBox ab)
        {
            try
            {
                con.Open();
                string query = "update employeedetail set empDname='" + b.Text + "',empDaddress='" + c.Text + "', empDjoindate='" + d.Text + "', empDsalary='" + e.Text + "',empDcategories='" + ab.SelectedValue.ToString() + "'where empDId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product is Successfully update");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    class prod:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, ComboBox ab)
        {
            int originalPrice = 0;
            double discount, discountGiven, SalePrice;
            originalPrice = int.Parse(d.Text);
            discount = double.Parse(e.Text);
            discountGiven = originalPrice * (discount / 100);
            SalePrice = originalPrice - discountGiven;
            f.Text = SalePrice.ToString();
            try
            {
                con.Open();
                string query = "insert into product values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + ab.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added SuccessFully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from product where ProdId=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product is Successfully Delete");
            con.Close();

        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, ComboBox ab)
        {
            try
            {
                int originalPrice = 0;
                double discount, discountGiven, SalePrice;
                originalPrice = int.Parse(d.Text);
                discount = double.Parse(e.Text);
                discountGiven = originalPrice * (discount / 100);
                SalePrice = originalPrice - discountGiven;
                f.Text = SalePrice.ToString();
                con.Open();
                string query = "update Product set ProdName='" + b.Text + "',ProdQty='" + c.Text + "', ProdPrice='" + d.Text + "', ProdDiscount='" + e.Text + "',ProdFinal='" + f.Text + "',ProdCat='" + ab.SelectedValue.ToString() + "'where ProdId=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product is Successfully update");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class daily:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g)
        {
            try
            {
                con.Open();
                string query = "insert into Dailyren values (" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + g.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from Dailyren where sno=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();
        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g)
        {
            try
            {
                con.Open();
                string query = "update Dailyren set opencash='" + b.Text + "',credit= '" + c.Text + "',debit='" + d.Text + "',balance='" + e.Text + "',date='" + f.Text + "',where sno=" + g.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
    class sell
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public void Add(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, Label ab, Label dc)
        {
            try
            {
                con.Open();
                string query = "insert into sellingform values (" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + ab.Text + "','" + dc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add2(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, Label ab, Label dc)
        {
            try
            {
                con.Open();
                string query = "insert into Selling2 values (" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "','" + e.Text + "','" + ab.Text + "','" + dc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class cus:supermarket
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public override void Add(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            
            try
            {
                con.Open();
                string query = "insert into customer values(" + a.Text + ",'" + b.Text + "','" + c.Text + "','" + d.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added SuccessFully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Delete(TextBox a)
        {
            con.Open();
            string query = "delete from cutomer where Id=" + a.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();
        }
        public override void update(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            try
            {
                con.Open();
                string query = "update cutomer set Name='" + b.Text + "',contact='" + c.Text + "',Address='" + d.Text + "'where Id=" + a.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Add is Successfully update");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
