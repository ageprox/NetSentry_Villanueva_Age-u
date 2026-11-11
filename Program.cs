using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int ops = 0;
double rec = 0, max = 0;
string maxCli = "", opt = "";

while (opt != "3")
{
    Console.Clear();
    Console.WriteLine("=== NETSENTRY CIBERSEGURIDAD ===");
    Console.WriteLine("1. Nueva operacion\n2. Ver caja\n3. Salir");
    Console.Write("Opcion: ");
    opt = Console.ReadLine() ?? "";

    if (opt == "1")
    {
        Console.Clear();
        string cli = "";
        while (string.IsNullOrWhiteSpace(cli))
        {
            Console.Write("Nombre Cliente: ");
            cli = (Console.ReadLine() ?? "").Trim();

        }

        Console.WriteLine("\nServicios: 1.Auditoria (40€) | 2.Desinfeccion (60€) | 3.Bastion (90€)");
        string s = "";
        double pSrv = 0;
        string nSrv = "";
        while (s != "1" && s != "2" && s != "3")
        {
            Console.Write("Selecciona servicios (1-3): ");
            s = Console.ReadLine() ?? "";
            if (s == "1") { pSrv = 40; nSrv = "Auditoria"; }
            else if (s == "2") { pSrv = 60; nSrv = "Desinfeccion"; }
            else if (s == "3") { pSrv = 90; nSrv = "Bastionado"; }
        }

        bool ex1 = false, ex2 = false, ex3 = false;
        double pExt = 0;
        string e = "";
        while (e != "4")
        {
            Console.WriteLine($"\nExtras: 1.Copia (+20€) | 2.WiFi (+25€) | 3.Phishing (+30€) | 4.Continuar");
            Console.Write("Opcion (1-4): ");
            e = Console.ReadLine() ?? "";
            if (e == "1") { if (ex1) Console.WriteLine("[AVISO] Ya añadido"); else { ex1 = true; pExt += 20; } }
            else if (e == "2") { if (ex2) Console.WriteLine("[AVISO] Ya añadido"); else { ex2 = true; pExt += 25; } }
            else if (e == "3") { if (ex3) Console.WriteLine("[AVISO] Ya añadido"); else { ex3 = true; pExt += 30; } }
        }

        Console.Write("\nModalidad (1.Estandar | 2.Urgente +20%): ");
        string mod = Console.ReadLine() ?? "";

        double sub = pSrv + pExt;
        double desc = (sub > 80) ? sub * 0.10 : 0;
        double sup = (mod == "2") ? (sub - desc) * 0.20 : 0;
        double tot = sub - desc + sup;


        Console.WriteLine($"\nTOTAL A PAGAR: {tot:F2} €");
        double pago = 0;
        while (pago < tot)

        {
            Console.WriteLine("Dineeo entregado (€): ");
            double.TryParse(Console.ReadLine() ?? "", out pago);
            if (pago < tot) Console.WriteLine("[ERROR] Pago insuficiente.");
        }

        ops++;
        rec += tot;
        if (ops == 1 || tot > max) { max = tot; maxCli = cli; }

        Console.Clear();
        Console.WriteLine("=== TICKET NETSENTRY ===");
        Console.WriteLine($"Op #{ops} | Cliente: {cli}\nServicio: {nSrv} ({pSrv:F2}€)");
        Console.WriteLine($"Extras: {pExt:F2}€ | Desc: -{desc:F2}€ | Urgencia: +{sup:F2}€");
        Console.WriteLine($"TOTAL: {tot:F2}€ | Pago: {pago:F2}€ | Cambio: {(pago - tot):F2}€");
        Console.WriteLine("\nENTER para volver...");
        Console.ReadLine();
    }
    else if (opt == "2")
    {
            Console.Clear();
            Console.WriteLine("=== CAJA Y ESTADISTICAS ===");
            if (ops == 0) Console.WriteLine("Sin operaciones registradas. ");
            else Console.WriteLine($"Cobradas: {ops}\nRecaudacion: {rec:F2}€\nMedia: {(rec / ops):F2}€\nMaximo: {max:F2}€ ({maxCli})");
            Console.WriteLine("\nENTER para volver...");
            Console.ReadLine();
    }

}
