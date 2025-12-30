var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='utf-8' />
    <title>Fourth Coffee - Home</title>
    <style>
        body { font-family: 'Segoe UI', sans-serif; background: #fdfaf7; color: #4e342e; margin: 0; }
        header { background: #3e2723; color: white; padding: 1rem 10%; display: flex; justify-content: space-between; align-items: center; }
        .site-title a { color: #d7ccc8; text-decoration: none; font-size: 1.5rem; font-weight: bold; }
        nav ul { list-style: none; display: flex; gap: 20px; }
        nav a { color: white; text-decoration: none; }
        #page { max-width: 1000px; margin: 0 auto; background: white; min-height: 100vh; box-shadow: 0 0 20px rgba(0,0,0,0.05); }
        #body { padding: 2rem 10%; }
        #featuredProduct { display: flex; gap: 20px; background: #efebe9; padding: 20px; border-radius: 8px; margin-bottom: 30px; }
        #featuredProduct img { width: 200px; border-radius: 8px; }
        .order-button { background: #795548; color: white; padding: 10px 20px; text-decoration: none; border-radius: 4px; display: inline-block; }
        .product { display: flex; justify-content: space-between; align-items: center; border-bottom: 1px solid #eee; padding: 15px 0; list-style: none; }
        .product-image { width: 80px; height: 80px; border-radius: 50%; object-fit: cover; margin-right: 15px; }
        .productInfo { display: flex; align-items: center; }
        .price { font-weight: bold; color: #2e7d32; font-size: 1.2rem; }
        footer { text-align: center; padding: 20px; font-size: 0.8rem; color: #8d6e63; }
    </style>
</head>
<body>
    <div id='page'>
        <header>
            <p class='site-title'><a href='/'>Fourth Coffee</a></p>
            <nav>
                <ul>
                    <li><a href='/'>Home</a></li>
                    <li><a href='/About'>About Us</a></li>
                </ul>
            </nav>
        </header>
        <div id='body'>
            <h1>Welcome to Fourth Coffee!</h1>
            <div id='featuredProduct'>
                <img alt='Featured Product' src='https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=200'/>
                <div id='featuredProductInfo'>
                    <h2>Pear Tart</h2>
                    <p class='price'>$5.99</p>
                    <p class='description'>A glazed pear tart topped with sliced almonds and a dash of cinnamon</p>
                    <a class='order-button' href='/order/6'>Order Now</a>
                </div>
            </div>

            <div id='productsWrapper'>
                <ul id='products'>
                    <li class='product'>
                        <div class='productInfo'>
                            <img class='product-image' src='https://images.unsplash.com/photo-1578985545062-69928b1d9587?w=80' />
                            <div>
                                <h3>Carrot Cake</h3>
                                <p class='description'>A scrumptious mini-carrot cake encrusted with sliced almonds</p>
                            </div>
                        </div>
                        <div class='action'>
                            <p class='price'>$8.99</p>
                            <a class='order-button' href='/order/1'>Order Now</a>
                        </div>
                    </li>
                    <li class='product'>
                        <div class='productInfo'>
                            <img class='product-image' src='https://images.unsplash.com/photo-1519915028121-7d3463d20b13?w=80' />
                            <div>
                                <h3>Lemon Tart</h3>
                                <p class='description'>A delicious lemon tart with fresh meringue cooked to perfection</p>
                            </div>
                        </div>
                        <div class='action'>
                            <p class='price'>$9.99</p>
                            <a class='order-button' href='/order/2'>Order Now</a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <footer>
            &copy; 2025 - Fourth Coffee
        </footer>
    </div>
</body>
</html>
", "text/html"));

app.Run();
