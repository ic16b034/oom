using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Main_program
    {
        public static void Main(string[] args)
        {

            var koerper = new Form[]
            {
                new Rechteck("Test_1",2,1,1),
                new Würfel(1),
                new Rechteck("Test_2",2,1,1),
                new Würfel(2),
                new Rechteck("Test_3",1,1,2),
                new Würfel(4),
                new Rechteck("Test_4",3,1,1)

            };

            //-------------------------------------------------------------------------------------------------------
            // 1. serialize a single book to a JSON string
            Console.WriteLine(JsonConvert.SerializeObject(koerper));

            // 2. ... with nicer formatting
            Console.WriteLine(JsonConvert.SerializeObject(koerper, Formatting.Indented));

            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(koerper, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(koerper, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Form[]>(textFromFile, settings);

            //-----------------------------------------------------------------------------------------------------------------------

            var source1 = new Subject<Form>();

            source1
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(i => Console.WriteLine($"received {i}"))
                ;

            var a = new Thread(() =>
            {
                var i = 0;
                while(true)
                {
                    Thread.Sleep(550);
                    var form = new Rechteck("Test", i++, i++, 1);
                    Console.WriteLine("test "+form.breiteRechteck+"test2 "+ form.laengeRechteck);
                   
                }

            });
            a.Start();

            //-------------------------------------------------------------------------------------------------------------------------

            var source = new Subject<Form>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => Console.WriteLine($"received {x}"))
                ;

            var t = new Thread(() =>
            {
                var i = 0;
                foreach (var x in koerper)
                {
                    Thread.Sleep(250);
                    source.OnNext(x);
                    Console.WriteLine($"sent {x}");
                    i++;
                }
 
            });
            t.Start();

            //-------------------------------------------------------------------------------------------


            /*
                        Console.WriteLine("Länge 1");
                        Rechteck ys = new[] Rechteck;
                        ys = koerper.Where(x => x == 1);
                        foreach (var y in ys) Console.WriteLine(y);


                        Console.WriteLine("Breite 1");
                        ys = koerper.Select(x => x == 1);
                        foreach (var y in ys) Write(y + " "); WriteLine();

                        var p_rechtecke = new Subject<Rechteck>();

                        p_rechtecke.Subscribe(x => Console.WriteLine($"received value {x}"));

                        while (true)
                        {
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                            p_rechtecke.OnNext("test", 1, 1, 1); // push value i to subscribers

                        }
                        */


        }
    }
}
    
