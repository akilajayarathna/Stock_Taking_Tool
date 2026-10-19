using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Taking_Tool
{
    public static class cls_MachineInfo
    {
        public static string GetprocessorId()
        {
			try
			{
				using (var searacher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor"))
				{
					foreach (ManagementObject mo in searacher.Get())
					{
						object v = mo["ProcessorId"];
						if(v != null && v.ToString().Trim() != "") 
						{
							return v.ToString().Trim();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
            return "";
        }
    }
}
