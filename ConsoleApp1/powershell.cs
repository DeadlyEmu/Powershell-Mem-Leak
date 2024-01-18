using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class powershell
    {

        public static async Task Trigger()
        {
                PowerShell ps = PowerShell.Create();
                ScriptBlock scriptBlock = ScriptBlock.Create($@"Import-Module RemoteDesktop
                Get-RDUserSession");
                ps.AddScript("& $args[0]").AddArgument(scriptBlock);

                StringBuilder sb = new StringBuilder();

                var pipelineObjects = await ps.InvokeAsync().ConfigureAwait(false);
                foreach (var item in pipelineObjects)
                {
                    sb.AppendLine(item.ToString());
                }
                pipelineObjects.Dispose();
                Console.Write(sb.ToString());
                ps.Dispose();
        }
    }
}
