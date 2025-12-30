var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Common CSS to make both pages look consistent
string sharedStyles = @"
    <style>
        body { font-family: 'Segoe UI', sans-serif; background: #fdfaf7; color: #4e342e; margin: 0; }
        header { background: #3e2723; color: white; padding: 1rem 10%; display: flex; justify-content: space-between; align-items: center; }
        .site-title a { color: #d7ccc8; text-decoration: none; font-size: 1.5rem; font-weight: bold; }
        nav ul { list-style: none; display: flex; gap: 20px; padding: 0; }
        nav a { color: white; text-decoration: none; font-weight: bold; }
        nav a:hover { text-decoration: underline; }
        #page { max-width: 1000px; margin: 0 auto; background: white; min-height: 100vh; box-shadow: 0 0 20px rgba(0,0,0,0.05); }
        #body { padding: 2rem 10%; line-height: 1.6; }
        #featuredProduct { display: flex; gap: 20px; background: #efebe9; padding: 20px; border-radius: 8px; margin-bottom: 30px; }
        #featuredProduct img { width: 200px; border-radius: 8px; }
        .order-button { background: #795548; color: white; padding: 10px 20px; text-decoration: none; border-radius: 4px; display: inline-block; }
        .product { display: flex; justify-content: space-between; align-items: center; border-bottom: 1px solid #eee; padding: 15px 0; list-style: none; }
        .product-image { width: 80px; height: 80px; border-radius: 50%; object-fit: cover; margin-right: 15px; }
        .productInfo { display: flex; align-items: center; }
        .price { font-weight: bold; color: #2e7d32; font-size: 1.2rem; }
        footer { text-align: center; padding: 20px; font-size: 0.8rem; color: #8d6e63; border-top: 1px solid #eee; margin-top: 20px; }
        h1 { color: #3e2723; }
    </style>";

// ROUTE 1: Home Page
app.MapGet("/", () => Results.Content($@"
<!DOCTYPE html>
<html>
<head>
    <title>Uday & keerthi Coffee Center - Home</title>
    {sharedStyles}
</head>
<body>
    <div id='page'>
        <header>
            <p class='site-title'><a href='/'>UK Coffee Center</a></p>
            <nav><ul><li><a href='/'>Home</a></li><li><a href='/About'>About Us</a></li></ul></nav>
        </header>
        <div id='body'>
            <h1>Welcome to UK Coffee Center!</h1>
            <div id='featuredProduct'>
                <img src='https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=200' />
                <div>
                    <h2>Pear Tart</h2>
                    <p class='price'>$5.99</p>
                    <p>A glazed pear tart topped with sliced almonds and a dash of cinnamon.</p>
                    <a class='order-button' href='#'>Order Now</a>
                </div>
            </div>
        </div>
        <footer>&copy; 2025 - UK Coffee Center</footer>
    </div>
</body>
</html>", "text/html"));

// ROUTE 2: About Page
app.MapGet("/About", () => Results.Content($@"
<!DOCTYPE html>
<html>
<head>
    <title>UK Coffee Center- About Us</title>
    {sharedStyles}
</head>
<body>
    <div id='page'>
        <header>
            <p class='site-title'><a href='/'>UK Coffee Center</a></p>
            <nav><ul><li><a href='/'>Home</a></li><li><a href='/About'>About Us</a></li></ul></nav>
        </header>
        <div id='body'>
            <section id='main'>
                <h1>THIS IS uday & keerthi coffice center provides best coffice in the world.</h1>
                <p>
                    UK Coffee was founded in 2010 and delivers coffee and fresh baked goods right to your door. 
                    In another life, Bill Baker was a developer by day and pastry chef by night. 
                    But soon Bill's innate skills with all things involving butter, flour and sugar put him 
                    even more in demand than his programming talents...
                </p>
                <p>UK Coffee honors his tech background by employing a state of the art online ordering system!</p>
            </section>
        </div>
        <footer>&copy; 2025 - UK Coffee Center</footer>
    </div>
</body>
</html>", "text/html"));

app.Run();
