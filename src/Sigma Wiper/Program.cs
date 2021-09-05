/*MIT License
Copyright (c) 2021 Owersite (github.com/owersite)
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:


The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.



THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/



















using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Sigma_Wiper
{
    class Program
    {
        static void Main()
        {
            os();
            menu();
        }
        static bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(OSPlatform.Windows);
        static bool isLinux = System.Runtime.InteropServices.RuntimeInformation
                                           .IsOSPlatform(OSPlatform.Linux);
        static bool isMacOs = System.Runtime.InteropServices.RuntimeInformation
                                          .IsOSPlatform(OSPlatform.OSX);
        static void os()
        {
            

            if (isWindows == true)
            {
                Console.Clear();
                Console.WriteLine("Detected windows! App is launching...");
                System.Threading.Thread.Sleep(300);
            }
            else if( isLinux == true)
            {
                Console.Clear();
                Console.WriteLine("You cannot use this app on linux yet! Sorry");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if( isMacOs == true)
            {
                Console.Clear();
                Console.WriteLine("You cannot use this app on MacOS yet! Sorry");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
           

        }
        static void menu()
        {
            Console.Title = "Sigma Wiper - Wipe Sigma Out!";
            //Console.SetWindowSize(60, 15);                 --- This cmd is only compatible with windows :/
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" _____ _                         _    _ _                 ");
            Console.WriteLine(@"/  ___(_)                       | |  | (_)                ");
            Console.WriteLine(@"\ `--. _  __ _ _ __ ___   __ _  | |  | |_ _ __   ___ _ __ ");
            Console.WriteLine(@" `--. \ |/ _` | '_ ` _ \ / _` | | |/\| | | '_ \ / _ \ '__|");
            Console.WriteLine(@"/\__/ / | (_| | | | | | | (_| | \  /\  / | |_) |  __/ |   ");
            Console.WriteLine(@"\____/|_|\__, |_| |_| |_|\__,_|  \/  \/|_| .__/ \___|_|   ");
            Console.WriteLine(@"          __/ |                          | |              ");
            Console.WriteLine(@"         |___/                           |_|              ");
            Console.WriteLine("");
            Console.WriteLine(" ");
            Console.WriteLine("Hello! Welcome to Sigma Wiper, here you go instructions on how to use it:");
            Console.WriteLine(" ");
            Console.WriteLine("[1] Erase Sigma");
            Console.WriteLine("[2] Give repository on github a star!");
            Console.WriteLine("[3] Close Program");

            process();
        }






        




        static void process()
        {
            string answer = Console.ReadLine();

            //Checking answer from 
            if(answer == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Starting Sigma Wiper!");

                if (isWindows)
                {
                    string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                    //Allocating Dir's
                    string sigmaDataDir = $"{path}" + @"\Roaming\.minecraft\sigma";
                    string sigma5datadir = $"{path}" + @"\Roaming\.minecraft\sigma5";
                    string sigmajellodatadir = $"{path}" + @"\Roaming\.minecraft\jello";
                    string sigmaCapitalizedDataDir = $"{path}" + @"\Roaming\.minecraft\Sigma";
                    string SigmaVerDir = $"{path}" + @"\Roaming\.minecraft\versions\Sigma";
                    string Sigma5VerDir = $"{path}" + @"\Roaming\.minecraft\versions\Sigma5";
                    string jellolauncher = $"{path}" + @"\Roaming\.minecraft\SigmaJelloPrelauncher.jar";
                    //Allocated

                    if (File.Exists(jellolauncher))
                    {
                        
                        
                        try
                        {
                            File.Delete(jellolauncher);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Jello Pre Launcher!");

                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Jello Pre Launcher, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Jello Pre Launcher!");

                         
                    }
                    if (Directory.Exists(SigmaVerDir))
                    {


                        try
                        {
                            Directory.Delete(SigmaVerDir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Sigma Version Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma Version dir, close minecraft and retry, if error still occurs restart your pc.");
                        }
                       
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Sigma Version Dir!");


                    }
                    if (Directory.Exists(sigmaCapitalizedDataDir))
                    {


                        try
                        {
                            Directory.Delete(sigmaCapitalizedDataDir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Capitalized Data Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma Capitalized data dir, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have capitalized data Dir!");


                    }



                    if (Directory.Exists(sigmajellodatadir))
                    {


                        try
                        {
                            Directory.Delete(sigmajellodatadir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Sigma jello Data Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma Jello data dir, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Sigma Jello data Dir!");


                    }


                    //Added since of v5 sigma update
                    if (Directory.Exists(Sigma5VerDir))
                    {


                        try
                        {
                            Directory.Delete(Sigma5VerDir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Sigma5 Versions Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma5 Versions dir, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Sigma5 Versions Dir!");


                    }















                    if (Directory.Exists(sigma5datadir))
                    {


                        try
                        {
                            Directory.Delete(sigma5datadir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Sigma5 Data Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma5 data dir, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Sigma5 data Dir!");


                    }

                    if (Directory.Exists(sigmaDataDir))
                    {


                        try
                        {
                            Directory.Delete(sigma5datadir, true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Deleted Sigma Data Dir!");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot delete Sigma data dir, close minecraft and retry, if error still occurs restart your pc.");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("You do not have Sigma data Dir!");


                    }
                }









                Console.WriteLine(" ");
                Console.ResetColor();
                Console.WriteLine("Press any key to go back to main menu");
                Console.ReadKey();
                menu();
            }
            else if (answer == "2")
            {
                Console.Clear();
                Process site = new Process();
                site.StartInfo.UseShellExecute = true;
                site.StartInfo.FileName = "https://github.com/owersite/sigma-wiper/";
                site.Start();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Opened site! Be sure to star it & follow owner of it.");
                Console.WriteLine(" ");
                Console.ResetColor();
                Console.WriteLine("Press any key to go back to menu!");
                Console.ReadKey();
                menu();

            }
            else if(answer=="3"){
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Flase Usage ! - You should press '1'' or '2' ");
                Console.WriteLine(" ");
                Console.ResetColor(); 
                Console.Write("Press any key to go back to main menu!");
                Console.ReadKey();
                menu();
            }
        }
        
    }
}


//woo hoo 400 linez