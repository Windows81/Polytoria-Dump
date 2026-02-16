namespace MoonSharp.Interpreter.CoreLib
{
	[MoonSharpModule]
	public class LoadModule
	{
		[MoonSharpModuleMethod]
		public const string require = "\nfunction(modulename)\n\tif (package == nil) then package = { }; end\n\tif (package.loaded == nil) then package.loaded = { }; end\n\n\tlocal m = package.loaded[modulename];\n\n\tif (m ~= nil) then\n\t\treturn m;\n\tend\n\n\tlocal func = __require_clr_impl(modulename);\n\n\tlocal res = func(modulename);\n\n\tif (res == nil) then\n\t\tres = true;\n\tend\n\n\tpackage.loaded[modulename] = res;\n\n\treturn res;\nend";

		public static void MoonSharpInit(Table globalTable, Table ioTable)
		{
		}

		[MoonSharpModuleMethod]
		public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[MoonSharpModuleMethod]
		public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		[MoonSharpModuleMethod]
		public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[MoonSharpModuleMethod]
		public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			return null;
		}

		private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext)
		{
			return null;
		}

		[MoonSharpModuleMethod]
		public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		[MoonSharpModuleMethod]
		public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}
	}
}
