﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator;
using Humanizer;


public static partial class  CSharpCodeGenerator
{
	public static void ClientConnectionObserverImpl(TextWriter writer, string ClassName, string prefix,string interfaceName, List<Function> Functions)
	{
		writer.WriteLine("// Generated by the rpc compiler.  DO NOT EDIT!");
		writer.WriteLine("using System;");
		writer.WriteLine("using System.Collections;");
		writer.WriteLine("using System.Threading.Tasks;");
		writer.WriteLine("using System.Collections.Generic;");
		writer.WriteLine("using Network;");
		writer.WriteLine("using ProtoBuf;");
		writer.WriteLine("using DataContract;");
		writer.WriteLine();
		writer.WriteLine("namespace " + "GrainInterface");
		writer.WriteLine("{");
		writer.WriteLine("");
		writer.WriteLine("\tpublic partial class " + ClassName + ":"+interfaceName);
		writer.WriteLine("\t{");

		foreach (Function current in Functions)
		{
			writer.Write(Utility.CreateCSharpComment("        ", current.Comment));

			var args = "(";
			args += current.ArgString();
			args += ")";

			writer.WriteLine("\t\tpublic void " + current.FunctionName + args);
			writer.WriteLine("\t\t{");

			writer.WriteLine("\t\t\t"+
				"var d = new "+
				Utility.GetArgType(prefix, current) + "();"
				);
			foreach (var argument in current.Args)
			{
				writer.WriteLine("\t\t\td." + argument.Name.Pascalize() + " = " + argument.Name+";");
			}
			writer.WriteLine("");
			writer.WriteLine("\t\t\tvar desc = new ServiceDesc();");
			writer.WriteLine("\t\t\tdesc.Type = 1;");
			writer.WriteLine("\t\t\tdesc.FuncId = "+current.Id+";");

			writer.WriteLine("\t\t\tconn.Send(desc, d);");

			writer.WriteLine("\t\t}");
			writer.WriteLine("");

		}
		writer.WriteLine("\t}");
		writer.WriteLine("}");
	}

}

