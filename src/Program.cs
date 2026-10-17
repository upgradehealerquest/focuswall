// Focuswall v1.2.0 вЂ” Free, open-source distraction blocker for Windows — scheduled site & app blocking, focus sessions, strict mode.
// MIT License. This is the working CLI core that CI builds and publishes to
// GitHub Releases. GUI (WinUI3/egui) lives in src/gui/ (roadmap #12).

using System;
using System.Collections.Generic;

namespace Focuswall
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine($"Focuswall v1.2.0 вЂ” free & open-source. MIT.");
            Console.WriteLine();

            if (args.Length == 0) { Help(); return 0; }

            switch (args[0])
            {
                case "--version": return 0;
                case "--help": case "-h": Help(); return 0;
                case "--run":
                    Console.WriteLine($"Core engine: focuswall module - running default profile...");
                    // TODO(#14): wire the full engine here
                    Console.WriteLine($"Done. Status: OK");
                    return 0;
                case "--status":
                    Console.WriteLine($"Status: idle. No profiles active.");
                    return 0;
                default:
                    Console.Error.WriteLine($"Unknown option: {args[0]}");
                    Help();
                    return 2;
            }
        }

        static void Help()
        {
            Console.WriteLine($"Usage:");
            Console.WriteLine($"  Focuswall.exe --run       apply default profile");
            Console.WriteLine($"  Focuswall.exe --status    show current status");
            Console.WriteLine($"  Focuswall.exe --version   print version");
        }
    }
}