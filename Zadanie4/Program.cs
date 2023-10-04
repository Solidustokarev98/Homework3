Console.WriteLine("Проверка класса веб-сайт");
Website myWebsite = new Website();
myWebsite.InputData();
myWebsite.DisplayData();
string websiteName = myWebsite.GetSiteName();
myWebsite.SetSiteName("Новое название сайта");
