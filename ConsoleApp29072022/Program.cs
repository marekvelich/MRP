using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp29072022;


namespace ConsoleApp29072022
{
    class Program
    {
        struct Costs
        {
           public double material;
           public double machine;
           public double employee;
        }

        static void Main(string[] args)
        {
            List<KeyValuePair<int, Product>> products = new List<KeyValuePair<int, Product>>();

            Costs productionCosts;
            { 
                productionCosts.material = 0;
                productionCosts.machine = 0;
                productionCosts.employee = 0;
            }

            int carAmount = 0;
            int truckAmount = 0;
            int ferryAmount = 0;

            //Machines
            Lathe LS01 = new Lathe("Small lathe", 2003 , "production", 80, 6000);
            Lathe LL01 = new Lathe("Large lathe", 2002 , "production", 120, 5000);
            var L01S = new Lathe.LatheSpecial("Lathe special", 2005 , "production", 140, 12000);
            var L02S = new Lathe.LatheSpecial("Lathe Special", 2016 , "production", 90, 12000);

            CuttingMachine CM01 = new CuttingMachine("Cutting machine", 2004, "preparation", 4);

            Xray XS01 = new Xray("Small Xray", 2017, "preparation", 100, 50);
            Xray XL01 = new Xray("Large Xray", 2017, "preparation", 120, 164);            
            Xray XS02 = new Xray("Small Xray", 2019, "finishing", 120, 50);
            Xray XL02 = new Xray("Large Xray", 2020, "finishing", 130, 350);

            Drill D01 = new Drill("Drill", 2016, "manufacturing", 60, 250, "diamond", 118);
            Drill D02 = new Drill("Drill", 2016, "manufacturing", 60, 250, "HSS", 135);

            WeldingMachine WM01 = new WeldingMachine("Welding machine", 2001, "manufacturing", 130, "TIG");
            WeldingMachine WM02 = new WeldingMachine("Welding machine", 2001, "manufacturing", 200, "MIG");
          
            //Employees
            Employee warehouseman = new Employee(10);
            Employee manufacturer = new Employee(9);
            Employee qualityController = new Employee(11);

            //Material
            Material steel = new Material("Steel - 1,98% C", 1.2);
            Material steelSi = new Material("Steel - 1,12% C, 0,6% Si", 1.4);
            Material steelMn = new Material("Steel - 1,34% C, 0,08% Mn", 1.5);
            Material castIron = new Material("castIron - 2,44% C", 0.9);
            Material aluminium = new Material("Aluminium", 2.4);
            Material dural = new Material("Aluminium - 93% Al, 4% Cu, 0,5% Mn, 0,3% Mg", 2.8);
            Material plasticPP = new Material("Polypropylene", 1.1);
            Material plasticPTFE = new Material("Polytetrafluorethylen", 1.2);

            //Operations
            Operation WeldingTIG = new Operation("Welding without extra material usage", WM01, 15, castIron, 40, manufacturer);
            Operation WeldingMIG = new Operation("Welding with extra material usage", WM02, 20, steelSi, 40, steel, 0.1,  manufacturer);
            Operation DrillingDia = new Operation("Drilling 8 x 2.5mm into dural deck plate", D01, 20, dural, 5,  manufacturer);
            Operation DrillingHSS = new Operation("Drilling 8 x 2.5mm into stellMn deck plate", D02, 20, dural, 5,  manufacturer);
            Operation XrayEntryS = new Operation("Entry Xray small part", XS01, 4, qualityController);
            Operation XrayEntryL = new Operation("Entry Xray small part", XL01, 7, qualityController);
            Operation XrayOutputS = new Operation("Entry Xray small part", XS02, 5, qualityController);
            Operation XrayOutputL = new Operation("Entry Xray small part", XL02, 8, qualityController);
            Operation Cutting = new Operation("Material cutting", CM01, 15, manufacturer);
            Operation TurningS = new Operation("Turning small part on small lathe", LS01, 23, steelMn, 80, manufacturer);
            Operation TurningL = new Operation("Turning large part on large lathe", LL01, 40, aluminium, 90, manufacturer);
            Operation TurningSS = new Operation("Turning small part on special small lathe", L01S, 15, plasticPP, 30, manufacturer);
            Operation TurningLS = new Operation("Turning large part on special large lathe", L02S, 19, plasticPTFE, 45, manufacturer);
            Operation TransportS = new Operation("Transport - short distance", 4, warehouseman);
            Operation TransportM = new Operation("Transport - medium distance", 8, warehouseman);
            Operation TransportL = new Operation("Transport - long distance", 12, warehouseman);

            //Components
            Component gearbox = new Component();
            gearbox.operations.Add(TransportS);
            gearbox.operations.Add(TurningL);
            gearbox.operations.Add(DrillingDia);
            gearbox.operations.Add(TransportL);
            gearbox.operations.Add(XrayOutputL);

            Component shaft = new Component();
            gearbox.operations.Add(XrayEntryS);
            gearbox.operations.Add(TurningSS);
            gearbox.operations.Add(DrillingHSS);
            gearbox.operations.Add(TurningLS);
            gearbox.operations.Add(TransportS);

            Component flange = new Component();
            gearbox.operations.Add(DrillingDia);
            gearbox.operations.Add(TransportM);
            gearbox.operations.Add(WeldingTIG);
            gearbox.operations.Add(TurningS);
            gearbox.operations.Add(XrayOutputS);

            Component platform = new Component();
            gearbox.operations.Add(XrayEntryL);
            gearbox.operations.Add(TransportL);
            gearbox.operations.Add(WeldingMIG);
            gearbox.operations.Add(Cutting);
            gearbox.operations.Add(TransportM);

            Component engine = new Component();
            gearbox.operations.Add(XrayEntryS);
            gearbox.operations.Add(TransportM);
            gearbox.operations.Add(WeldingTIG);
            gearbox.operations.Add(DrillingHSS);
            gearbox.operations.Add(TransportL);

            Component truckBed = new Component();
            gearbox.operations.Add(DrillingHSS);
            gearbox.operations.Add(TransportL);
            gearbox.operations.Add(TurningS);
            gearbox.operations.Add(WeldingTIG);
            gearbox.operations.Add(XrayOutputS);

            Component propeller = new Component();
            gearbox.operations.Add(XrayEntryS);
            gearbox.operations.Add(TransportM);
            gearbox.operations.Add(TurningS);
            gearbox.operations.Add(DrillingDia);
            gearbox.operations.Add(XrayOutputS);

            //Products
            Product car = new Product("cars", 380, products, carAmount);
            car.component.Add(gearbox);
            car.component.Add(platform);
            car.component.Add(engine);
            car.component.Add(shaft);
            car.component.Add(flange);

            Product truck = new Product("trucks", 420, products, truckAmount);
            truck.component.Add(gearbox);
            truck.component.Add(platform);
            truck.component.Add(engine);
            truck.component.Add(shaft);
            truck.component.Add(flange);
            truck.component.Add(truckBed);

            Product ferry = new Product("ferries", 650, products, ferryAmount);
            ferry.component.Add(gearbox);
            ferry.component.Add(platform);
            ferry.component.Add(engine);
            ferry.component.Add(shaft);
            ferry.component.Add(flange);
            ferry.component.Add(propeller);
         
            foreach (KeyValuePair<int, Product> kvp in products)
            {
                Console.WriteLine("Please enter the amount of " + kvp.Value.NamePlural + " to be produced: ");

                int amount = NumberInputHandle.IsValid(kvp);

                var newEntry = new KeyValuePair<int, Product>(amount, kvp.Value);

                double machCosts = CostsCalculation.MachineCosts(newEntry.Key, newEntry.Value);
                productionCosts.machine += machCosts;

                double matCosts = CostsCalculation.MaterialCosts(newEntry.Key, newEntry.Value);
                productionCosts.material += matCosts;

                double empCosts = CostsCalculation.EmployeeCosts(newEntry.Key, newEntry.Value);
                productionCosts.employee += empCosts;
            }

            Console.WriteLine("Total machine costs are: " + productionCosts.machine);
            Console.WriteLine("Total material costs are: " + productionCosts.material);
            Console.WriteLine("Total employee costs are: " + productionCosts.employee);    

            Console.ReadLine();
        }
    }
}
