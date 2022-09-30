Coube c = new Coube();
c.Create();
c.Print();

Palindrom P = new Palindrom();
P.Create();
P.Print();
P.Revers();
P.Proverka();

DelElem Del = new DelElem();
Del.Create();
Del.Print();
Del.Remove();

Veb V = new Veb();
V.Create();
V.Print();
Console.WriteLine("Введите название сайта");
V.Name = Console.ReadLine();
Console.WriteLine(V.Name);
Console.WriteLine("Введите путь к сайту");
V.Path = Console.ReadLine();
Console.WriteLine(V.Path);
Console.WriteLine("Введите описание сайта");
V.Opis = Console.ReadLine();
Console.WriteLine(V.Opis);
Console.WriteLine("Введите IP сайта");
V.IP = Console.ReadLine();
Console.WriteLine(V.IP);

Magazine M = new Magazine();
M.Create();
M.Print();

Shop S = new Shop();
S.Create();
S.Print();


class Coube
{
    public int l;
    char s;
    char p = ' ';
    public Coube() { }
    public void Create()
    {
        Console.WriteLine("Введите размер стороны: ");
        l = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите символ: ");
        s = (char)Console.Read();
    }
    public void Print()
    {
       
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < l; j++)
            {
                if (i == 0 | j == 0 | i == l - 1 | j == l - 1)
                {
                    Console.Write(s+" ");
                }
                else
                {
                    Console.Write(p+" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Palindrom
{
    public int elem;
    public int rev=0;
    public Palindrom()
    {
   
    }

    public void Create()
    {
        Console.WriteLine("Введите число");
        elem=int.Parse(Console.ReadLine());
        
        
    }
    public void Revers()
    {
        int v=elem;
        while(elem!=0)
        {
            rev=rev*10+elem%10;
            elem = elem / 10;
        }
        elem = v;
        Console.WriteLine(rev);
    }
    public void Proverka()
    {
        if(elem==rev)
        {
            Console.WriteLine("Polindrom");
        }
        else
        {
            Console.WriteLine("Ne Polindrom");
        }
    }
    public void Print()
    {
        Console.WriteLine(elem);
    }
}

class DelElem
{
    public int[] mas;
    public int[] mas2;

    public void Create()
    {
        Console.WriteLine("Введите размер оригинального массива");
        int q;
        q=int.Parse(Console.ReadLine());
        mas = new int[q];
        Console.WriteLine("Заполните оригинальный массив");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите размер фильтр массива");
        int q2;
        q2 = int.Parse(Console.ReadLine());
        mas2 = new int[q2];
        Console.WriteLine("Заполните фильтрующий массив");
        for (int i = 0; i < mas2.Length; i++)
        {
            mas2[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Remove()
    {
        int[] mas3=new int[mas.Length];
        int k = 0;
        Console.WriteLine();
        for (int i = 0; i < mas.Length; i++)
        {
            bool bolka = true;
            for (int j = 0; j < mas2.Length; j++)
            {
                if (mas[i] == mas2[j])
                {
                    bolka = false;
                    //mas3[k]=mas3[mas.Length - 1];
                    break;
                }
            }
            if (bolka)
            {
                mas3[k] = mas[i];
                Console.Write(mas3[k] + " ");
                k++;
            }
        }
    }
    public void Print()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i]+" ");
        }
        Console.WriteLine();
        for (int i = 0; i < mas2.Length; i++)
        {
            Console.Write(mas2[i] + " ");
        }
    }

}

class Veb
{
    public string nameSite;
    public string pathSite;
    public string opisSite;
    public string IpSite;
    public Veb() { }

    public string Name
    {
        get { return nameSite; }
        set { nameSite = value; }
    }
    public string Path
    {
        get { return pathSite; }
        set { pathSite = value; }
    }
    public string Opis
    {
        get { return opisSite; }
        set { opisSite = value; }
    }
    public string IP
    {
        get { return IpSite; }
        set { IpSite = value; }
    }
    public void Create()
    {
        Console.WriteLine("Введите название сайта");
        nameSite = Console.ReadLine();
        Console.WriteLine("Введите путь к сайту");
        pathSite = Console.ReadLine();
        Console.WriteLine("Введите описание сайта");
        opisSite = Console.ReadLine();
        Console.WriteLine("Введите IP сайта");
        IpSite = Console.ReadLine();

    }

    public void Print()
    {
        Console.WriteLine(nameSite);
        Console.WriteLine(pathSite);
        Console.WriteLine(opisSite);
        Console.WriteLine(IpSite);
    }
}

class Magazine
{
    public string nameM;
    public string dateM;
    public string opisM;
    public string EmailM;
    public Magazine() { }

    public string Name
    {
        get { return nameM; }
        set { nameM = value; }
    }
    public string Date
    {
        get { return dateM; }
        set { dateM = value; }
    }
    public string Opis
    {
        get { return opisM; }
        set { opisM = value; }
    }
    public string Email
    {
        get { return EmailM; }
        set { EmailM = value; }
    }
    public void Create()
    {
        Console.WriteLine("Введите название журнала");
        nameM = Console.ReadLine();
        Console.WriteLine("Введите дату основания");
        dateM = Console.ReadLine();
        Console.WriteLine("Введите описание журнала");
        opisM = Console.ReadLine();
        Console.WriteLine("Введите Емейл");
        EmailM = Console.ReadLine();

    }

    public void Print()
    {
        Console.WriteLine(nameM);
        Console.WriteLine(dateM);
        Console.WriteLine(opisM);
        Console.WriteLine(EmailM);
    }
}

class Shop
{
    public string nameM;
    public string adres;
    public string opisP;
    public string EmailS;
    public Shop() { }

    public string Name
    {
        get { return nameM; }
        set { nameM = value; }
    }
    public string Path
    {
        get { return adres; }
        set { adres = value; }
    }
    public string Opis
    {
        get { return opisP; }
        set { opisP = value; }
    }
    public string IP
    {
        get { return EmailS; }
        set { EmailS = value; }
    }
    public void Create()
    {
        Console.WriteLine("Введите название магазина");
        nameM = Console.ReadLine();
        Console.WriteLine("Введите адрес");
        adres = Console.ReadLine();
        Console.WriteLine("Введите описание магазина");
        opisP = Console.ReadLine();
        Console.WriteLine("Введите емейл");
        EmailS = Console.ReadLine();

    }

    public void Print()
    {
        Console.WriteLine(nameM);
        Console.WriteLine(adres);
        Console.WriteLine(opisP);
        Console.WriteLine(EmailS);
    }
}