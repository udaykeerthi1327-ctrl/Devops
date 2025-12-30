// Program.cs - A simple ASP.NET 8 Minimal API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(@" 
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Fourth Coffee - Home</title>
        <link href="/Content/Site.css" rel="stylesheet" />
        <link href="/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <script src="/Scripts/modernizr-2.5.3.js"></script>
        <script src="/Scripts/jquery-1.7.1.min.js"></script>
        
    </head>
    <body>
        <div id="page">
            <header>
                <p class="site-title"><a href="/">Fourth Coffee</a></p>
                <nav>
                    <ul>
                        <li><a href="/">Home</a></li>
                        <li><a href="/About">About Us</a></li>
                    </ul>
                </nav>
            </header>
            <div id="body">
                

<h1>Welcome to Fourth Coffee!</h1>

<div id="featuredProduct">
    <img alt="Featured Product" src="/Images/Products/pear_tart.jpg"/>
    <div id="featuredProductInfo">
        <div id="productInfo">
            <h2>Pear Tart</h2>
            <p class="price">$5.99</p>
            <p class="description">A glazed pear tart topped with sliced almonds and a dash of cinnamon</p>
        </div>
        <div id="callToAction">
            <a class="order-button" href="/order/6" title="Order Pear Tart">Order Now</a>
        </div>
    </div>
</div>

<div id="productsWrapper">
    <ul id="products" data-role="listview" data-inset="true">
            <li class="product">
                <a href="/order/1" title="Order Carrot Cake">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/carrot_cake.jpg" alt="Image of Carrot Cake" />
                
                    <div class="productInfo">
                        <h3>Carrot Cake</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/carrot_cake.jpg" alt="Image of Carrot Cake" />
                        <p class="description">A scrumptious mini-carrot cake encrusted with sliced almonds</p>
                        <p class="price hide-from-desktop">$8.99</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$8.99</p>
                    <a class="order-button" href="/order/1" title="Order Carrot Cake">Order Now</a>
                </div>
                 
            </li>
            <li class="product">
                <a href="/order/2" title="Order Lemon Tart">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/lemon_tart.jpg" alt="Image of Lemon Tart" />
                
                    <div class="productInfo">
                        <h3>Lemon Tart</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/lemon_tart.jpg" alt="Image of Lemon Tart" />
                        <p class="description">A delicious lemon tart with fresh meringue cooked to perfection</p>
                        <p class="price hide-from-desktop">$9.99</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$9.99</p>
                    <a class="order-button" href="/order/2" title="Order Lemon Tart">Order Now</a>
                </div>
                 
            </li>
            <li class="product">
                <a href="/order/3" title="Order Cupcakes">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/cupcakes.jpg" alt="Image of Cupcakes" />
                
                    <div class="productInfo">
                        <h3>Cupcakes</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/cupcakes.jpg" alt="Image of Cupcakes" />
                        <p class="description">Delectable vanilla and chocolate cupcakes</p>
                        <p class="price hide-from-desktop">$5.99</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$5.99</p>
                    <a class="order-button" href="/order/3" title="Order Cupcakes">Order Now</a>
                </div>
                 
            </li>
            <li class="product">
                <a href="/order/4" title="Order Bread">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/bread.jpg" alt="Image of Bread" />
                
                    <div class="productInfo">
                        <h3>Bread</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/bread.jpg" alt="Image of Bread" />
                        <p class="description">Fresh baked French-style bread</p>
                        <p class="price hide-from-desktop">$1.49</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$1.49</p>
                    <a class="order-button" href="/order/4" title="Order Bread">Order Now</a>
                </div>
                 
            </li>
            <li class="product">
                <a href="/order/6" title="Order Pear Tart">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/pear_tart.jpg" alt="Image of Pear Tart" />
                
                    <div class="productInfo">
                        <h3>Pear Tart</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/pear_tart.jpg" alt="Image of Pear Tart" />
                        <p class="description">A glazed pear tart topped with sliced almonds and a dash of cinnamon</p>
                        <p class="price hide-from-desktop">$5.99</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$5.99</p>
                    <a class="order-button" href="/order/6" title="Order Pear Tart">Order Now</a>
                </div>
                 
            </li>
            <li class="product">
                <a href="/order/7" title="Order Chocolate Cake">
                    <img class="hide-from-desktop" src="/Images/Products/Thumbnails/chocolate_cake.jpg" alt="Image of Chocolate Cake" />
                
                    <div class="productInfo">
                        <h3>Chocolate Cake</h3>
                        <img class="product-image hide-from-mobile" src="/Images/Products/Thumbnails/chocolate_cake.jpg" alt="Image of Chocolate Cake" />
                        <p class="description">Rich chocolate frosting cover this chocolate lover’s dream.    </p>
                        <p class="price hide-from-desktop">$8.99</p>                    
                    </div>
                </a>

                <!-- Desktop only -->
                <div class="action  hide-from-mobile">
                    <p class="price">$8.99</p>
                    <a class="order-button" href="/order/7" title="Order Chocolate Cake">Order Now</a>
                </div>
                 
            </li>
    </ul>
</div>
            </div>
            <footer>
                &copy;2025 - Fourth Coffee
            </footer>
        </div>
    </body>
</html>  
", "text/html"));

app.Run();
