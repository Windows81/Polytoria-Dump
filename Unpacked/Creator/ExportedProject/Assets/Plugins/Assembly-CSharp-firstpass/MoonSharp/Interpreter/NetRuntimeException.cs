using System;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter
{
	[Serializable]
	public class NetRuntimeException : InterpreterException
	{
		public NetRuntimeException(Exception ex)
			: base((Exception)null, (string)null)
		{
		}

		public NetRuntimeException(NetRuntimeException ex)
			: base((Exception)null, (string)null)
		{
		}

		public NetRuntimeException(string message)
			: base((Exception)null, (string)null)
		{
		}

		public NetRuntimeException(string format, params object[] args)
			: base((Exception)null, (string)null)
		{
		}

		public static NetRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null)
		{
			return null;
		}

		public static NetRuntimeException ConcatOnNonString(DynValue l, DynValue r)
		{
			return null;
		}

		public static NetRuntimeException LenOnInvalidType(DynValue r)
		{
			return null;
		}

		public static NetRuntimeException CompareInvalidType(DynValue l, DynValue r)
		{
			return null;
		}

		public static NetRuntimeException BadArgument(int argNum, string funcName, string message)
		{
			return null;
		}

		public static NetRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil)
		{
			return null;
		}

		public static NetRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil)
		{
			return null;
		}

		public static NetRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil)
		{
			return null;
		}

		public static NetRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected)
		{
			return null;
		}

		public static NetRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum)
		{
			return null;
		}

		public static NetRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName)
		{
			return null;
		}

		public static NetRuntimeException BadArgumentValueExpected(int argNum, string funcName)
		{
			return null;
		}

		public static NetRuntimeException IndexType(DynValue obj)
		{
			return null;
		}

		public static NetRuntimeException LoopInIndex()
		{
			return null;
		}

		public static NetRuntimeException LoopInNewIndex()
		{
			return null;
		}

		public static NetRuntimeException LoopInCall()
		{
			return null;
		}

		public static NetRuntimeException TableIndexIsNil()
		{
			return null;
		}

		public static NetRuntimeException TableIndexIsNaN()
		{
			return null;
		}

		public static NetRuntimeException ConvertToNumberFailed(int stage)
		{
			return null;
		}

		public static NetRuntimeException ConvertObjectFailed(object obj)
		{
			return null;
		}

		public static NetRuntimeException ConvertObjectFailed(DataType t)
		{
			return null;
		}

		public static NetRuntimeException ConvertObjectFailed(DataType t, Type t2)
		{
			return null;
		}

		public static NetRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType)
		{
			return null;
		}

		public static NetRuntimeException UserDataMissingField(string typename, string fieldname)
		{
			return null;
		}

		public static NetRuntimeException CannotResumeNotSuspended(CoroutineState state)
		{
			return null;
		}

		public static NetRuntimeException CannotYield()
		{
			return null;
		}

		public static NetRuntimeException CannotYieldMain()
		{
			return null;
		}

		public static NetRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null)
		{
			return null;
		}

		public static NetRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc)
		{
			return null;
		}

		public static NetRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc)
		{
			return null;
		}

		public override void Rethrow()
		{
		}
	}
}
