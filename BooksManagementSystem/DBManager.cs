using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BooksManagementSystem; 

public class DBManager
{
    private static MySqlConnection conn;

    // Connection String
    private static string connectionString = "SERVER = localhost; DATABASE = library; UID = root; PASSWORD = password;";

    static DBManager()
    {
        conn = new MySqlConnection(connectionString);
    }

    public static bool Connection()
    {
        try
        {
            conn.Open();

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }

    public static MySqlConnection GetConnection()
    {
        return conn;
    }

    public bool AuthenticateUser(string username, string password)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT COUNT(1) FROM admin WHERE admin_username=@Username AND admin_password=@Password";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
    }

    public bool PasswordsMatch(string password1, string password2)
    {
        return password1.Trim() == password2.Trim();
    }

    public bool UsernameExists(string username)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT COUNT(1) FROM admin WHERE admin_username = @Username";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }


    public void InsertUser(string username, string password) 
    {
        using (var conn = new MySqlConnection (connectionString)){
            conn.Open ();
            var query = "INSERT INTO admin (admin_username, admin_password) values (@username, @password)";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void InsertBooks(string title, string category, string isbn, string publication_year)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "INSERT INTO books (title, category, isbn, publication_year) values (@title, @category, @isbn, @publication_year)";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@publication_year", publication_year);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetAllBoks()
    {
        DataTable dt = new DataTable();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT book_id, title, category, isbn, publication_year from library.books";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using(var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

        }
        return dt;
    }

    public void UpdateBooks(string book_id, string title, string category, string isbn, string publication_year)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "UPDATE books SET title = @title, category = @category, isbn = @isbn, publication_year = @publication_year WHERE book_id = @book_id";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@book_id", book_id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@publication_year", publication_year);
                cmd.ExecuteNonQuery();
            }
        }
    }
    public DataTable GetAllCategories()
    {
        DataTable dt = new DataTable();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT category_id, category_name from library.categories";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

        }
        return dt;
    }
    public DataTable GetAllBorrow()
    {
        DataTable dt = new DataTable();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT borrow_id, user_id, book_id, borrow_date, book_category, b_status from library.borrow";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

        }
        return dt;
    }

    public DataTable GetAllUsers()
    {
        DataTable dt = new DataTable();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT user_id, first_name, last_name, email, phone from library.users";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

        }
        return dt;
    }

    public void DeleteBook(string book_id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "DELETE FROM books WHERE book_id = @book_id";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@book_id", book_id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void AddCategory(string catName)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "INSERT INTO categories (category_name) values (@category_name)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@category_name", catName);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DeleteCategory(string catId)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "DELETE FROM categories WHERE category_id = @category_id";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@category_id", catId);
                cmd.ExecuteNonQuery ();
            }
        }
    }

    public void BorrowBooks(string uid, string bid, string bdate, string bstatus)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            string bookCategory = null;
            var categoryQuery = "SELECT category FROM books WHERE book_id = @book_id";
            using (var categoryCmd = new MySqlCommand(categoryQuery, conn))
            {
                categoryCmd.Parameters.AddWithValue("@book_id", bid);
                using (var reader = categoryCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookCategory = reader["category"].ToString();
                    }
                    else
                    {
                        throw new Exception("Book not found.");
                    }
                }
            }


            var query = "INSERT INTO borrow (user_id, book_id, borrow_date, book_category, b_status) values (@user_id, @book_id, @borrow_date, @book_category, @b_status)";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", uid);
                cmd.Parameters.AddWithValue("@book_id", bid);
                cmd.Parameters.AddWithValue("@borrow_date", bdate);
                cmd.Parameters.AddWithValue("@book_category", bookCategory);
                cmd.Parameters.AddWithValue("@b_status", bstatus);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void UpdateStatus(string status, string bid)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open ();
            var query = "DELETE FROM borrow WHERE borrow_id = @borrow_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@borrow_id", bid);
                cmd.Parameters.AddWithValue("@b_status", status);
                cmd.ExecuteNonQuery () ;
            }
        }
    }

    public void AddUser(string fname, string lname, string email, string phone)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open ();
            var query = "INSERT INTO users (first_name, last_name, email, phone) values (@first_name, @last_name, @email, @phone)";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@first_name", fname);
                cmd.Parameters.AddWithValue("@last_name", lname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery ();
            }
        }
    }

    public bool EmailExists(string email)
    {
        bool exists = false;

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM users WHERE email = @email";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                long count = (long)cmd.ExecuteScalar();

                exists = count > 0;
            }
        }
        return exists;
    }

    public void UpdateUser(string user_id, string fname, string lname, string email, string phone)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open ();
            var query = "UPDATE users SET first_name = @first_name, last_name = @last_name, email = @email, phone = @phone WHERE user_id = @user_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@first_name", fname);
                cmd.Parameters.AddWithValue("@last_name", lname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public bool BookExists(string book_id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM books WHERE book_id = @book_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@book_id", book_id);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public bool UserExists(string user_id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM users WHERE user_id = @user_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", user_id);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public void DeleteUser(string user_id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM users WHERE user_id = @user_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public bool CanDeleteUser(string userId)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM borrow WHERE user_id = @user_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", userId);
                long count = (long)cmd.ExecuteScalar();
                return count == 0; // True if no active borrows
            }
        }
    }
    public DataTable ReturnedBooks()
    {
        DataTable dt = new DataTable();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var query = "SELECT * FROM returned_books";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

        }
        return dt;
    }

    public DataTable SearchReturnedBooks(string keyword)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = @"
            SELECT return_id, user_id, book_id, borrow_date, return_date, book_category, status
            FROM returned_books
            WHERE 
                CAST(user_id AS CHAR) LIKE @keyword
             OR CAST(book_id AS CHAR) LIKE @keyword
             OR DATE_FORMAT(borrow_date, '%Y-%m-%d') LIKE @keyword
             OR DATE_FORMAT(return_date, '%Y-%m-%d') LIKE @keyword
             OR CAST(book_category AS CHAR) LIKE @keyword
             OR status LIKE @keyword";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

    public DataTable FilterReturnedLog(string userId = null, string bookId = null, DateTime? returnDate = null)
    {
        DataTable dt = new DataTable();
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            string query = "SELECT * FROM returned_books WHERE status = 'Returned'";

            if (!string.IsNullOrEmpty(userId))
                query += " AND user_id = @userId";

            if (!string.IsNullOrEmpty(bookId))
                query += " AND book_id = @bookId";

            if (returnDate.HasValue)
                query += " AND DATE(return_date) = @returnDate";

            using (var cmd = new MySqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(userId))
                    cmd.Parameters.AddWithValue("@userId", userId);

                if (!string.IsNullOrEmpty(bookId))
                    cmd.Parameters.AddWithValue("@bookId", bookId);

                if (returnDate.HasValue)
                    cmd.Parameters.AddWithValue("@returnDate", returnDate.Value.ToString("yyyy-MM-dd"));

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }
        return dt;
    }

    public DataTable Filter(string selected)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM borrow WHERE book_category = @book_category";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@book_category", selected);

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
