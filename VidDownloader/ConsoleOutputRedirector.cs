namespace VidDownloader
{
    /// <summary>
    /// Console Output Redirector by MeowthK (kennotbeccin@gmail.com)
    /// - Displays console commands to supported (WinForms) Control.Text.
    /// </summary>
    class ConsoleOutputRedirector
    {
        private System.Windows.Forms.Control controlOutput;
        private string argument;
        private string filename;
        private string workingDirectory;

        public ConsoleOutputRedirector(System.Windows.Forms.Control ControlOutput, string FileName, string WorkingDirectory, string CommandArguments)
        {
            if (FileName == null || FileName.Length == 0)
                throw new System.Exception("Filename must not be empty.");

            if (ControlOutput == null)
                throw new System.Exception("Control is null");

            controlOutput = ControlOutput;
            argument = CommandArguments;
            filename = FileName;
            workingDirectory = WorkingDirectory;
        }

        public void ClearOutput()
        {
            controlOutput.Text = string.Empty;
        }

        public void ExecuteCommand()
        {
            using (var process = new System.Diagnostics.Process())
            {
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = argument;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;

                process.ErrorDataReceived += (o, e) =>
                {
                    CTCC.CrossThreadControlCall(controlOutput, () =>
                    {
                        if (e.Data != null )
                            controlOutput.Text += "\r\n[ERROR]: " + e.Data + "\r\n";
                    });
                };

                process.OutputDataReceived += (o, e) =>
                {
                    CTCC.CrossThreadControlCall(controlOutput, () =>
                    {
                        if (e.Data != null)
                            controlOutput.Text += e.Data + "\r\n";
                    });
                };

                process.Start();

                controlOutput.Text = "Please wait...\r\n";

                // Feed command to Console
                process.StandardInput.WriteLine(argument);

                // Begin Asynchronous reading of Console's StdError and StdOutput
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }
        }
    }
}
