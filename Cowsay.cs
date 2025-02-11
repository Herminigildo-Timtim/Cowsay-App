using System;
using System.Diagnostics;

static class CowsayApp
{
    public static void Say(string message)
    {
        try
        {
            ProcessStartInfo psi = new()
            {
                FileName = "/usr/games/cowsay", 
                Arguments = message, 
                RedirectStandardOutput = true,
                RedirectStandardError = true, 
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process? process = Process.Start(psi);

            if (process == null)
            {
                Console.WriteLine("Error: Unable to start cowsay process.");
                return;
            }

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error: {error}");
            }
            else
            {
                Console.WriteLine(output);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}