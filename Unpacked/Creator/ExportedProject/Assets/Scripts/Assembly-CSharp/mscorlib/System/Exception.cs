namespace System;

[ComVisible(True)]
[Token(Token = "0x2000188")]
public class Exception : ISerializable
{
	[Token(Token = "0x2000189")]
	public enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	[OptionalField]
	[Token(Token = "0x40005BD")]
	private static object s_EDILock; //Field offset: 0x0
	[Token(Token = "0x40005CE")]
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BE")]
	private string _className; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005BF")]
	internal string _message; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C0")]
	private IDictionary _data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C1")]
	private Exception _innerException; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C2")]
	private string _helpURL; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C3")]
	private object _stackTrace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C4")]
	private string _stackTraceString; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005C5")]
	private string _remoteStackTraceString; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005C6")]
	private int _remoteStackIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005C7")]
	private object _dynamicMethods; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005C8")]
	internal int _HResult; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005C9")]
	private string _source; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x40005CA")]
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005CB")]
	internal StackTrace[] captured_traces; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005CC")]
	private IntPtr[] native_trace_ips; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005CD")]
	private int caught_in_unmanaged; //Field offset: 0x88

	[Token(Token = "0x17000124")]
	public override IDictionary Data
	{
		[Address(RVA = "0x14DE170", Offset = "0x14DD370", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DCC")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000128")]
	public int HResult
	{
		[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD9")]
		 get { } //Length: 4
		[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DDA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000125")]
	public override Exception InnerException
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DCE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000123")]
	public override string Message
	{
		[Address(RVA = "0x14DE1E0", Offset = "0x14DD3E0", Length = "0x118")]
		[CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.Assertions.AssertionException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Net.Sockets.SocketException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ArgumentOutOfRangeException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AggregateException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MissingFieldException), Member = "get_Message", ReturnType = typeof(string))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000DCB")]
		 get { } //Length: 280
	}

	[Token(Token = "0x17000127")]
	public override string Source
	{
		[Address(RVA = "0x14DE300", Offset = "0x14DD500", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000DD2")]
		 get { } //Length: 327
	}

	[Token(Token = "0x17000126")]
	public override string StackTrace
	{
		[Address(RVA = "0x14DE450", Offset = "0x14DD650", Length = "0x3F")]
		[CalledBy(Type = "UnityEngine.AndroidJavaException", Member = "get_StackTrace", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000DCF")]
		 get { } //Length: 63
	}

	[Address(RVA = "0x14DDB50", Offset = "0x14DCD50", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DDF")]
	private static Exception() { }

	[Address(RVA = "0x14DDBD0", Offset = "0x14DCDD0", Length = "0x1F")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DC7")]
	public Exception() { }

	[Address(RVA = "0x14DE0D0", Offset = "0x14DD2D0", Length = "0x3B")]
	[CallerCount(Count = 172)]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DC8")]
	public Exception(string message) { }

	[Address(RVA = "0x14DE110", Offset = "0x14DD310", Length = "0x58")]
	[CalledBy(Type = "MoonSharp.Interpreter.InterpreterException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpRequestException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GameObject", "UnityEngine.EventSystems.BaseEventData", "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.SyntaxErrorException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.SyntaxErrorException"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.ScriptRuntimeException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptRuntimeException"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.ScriptRuntimeException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.NetRuntimeException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.NetRuntimeException"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.NetRuntimeException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.InterpreterException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeInitializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeInitializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IList`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IList`1<System.Exception>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ImmediateModeException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DC9")]
	public Exception(string message, Exception innerException) { }

	[Address(RVA = "0x14DDBF0", Offset = "0x14DCDF0", Length = "0x4D3")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DCA")]
	protected Exception(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14DCFA0", Offset = "0x14DC1A0", Length = "0xEB")]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DDD")]
	internal Exception FixRemotingException() { }

	[Address(RVA = "0x14DE170", Offset = "0x14DD370", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DCC")]
	public override IDictionary get_Data() { }

	[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD9")]
	public int get_HResult() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DCE")]
	public override Exception get_InnerException() { }

	[Address(RVA = "0x14DE1E0", Offset = "0x14DD3E0", Length = "0x118")]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Assertions.AssertionException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Sockets.SocketException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ArgumentOutOfRangeException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AggregateException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MissingFieldException), Member = "get_Message", ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DCB")]
	public override string get_Message() { }

	[Address(RVA = "0x14DE300", Offset = "0x14DD500", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000DD2")]
	public override string get_Source() { }

	[Address(RVA = "0x14DE450", Offset = "0x14DD650", Length = "0x3F")]
	[CalledBy(Type = "UnityEngine.AndroidJavaException", Member = "get_StackTrace", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000DCF")]
	public override string get_StackTrace() { }

	[Address(RVA = "0x14DD090", Offset = "0x14DC290", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DCD")]
	private string GetClassName() { }

	[Address(RVA = "0x14DD0F0", Offset = "0x14DC2F0", Length = "0x8D")]
	[CalledBy(Type = typeof(ThreadAbortException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadInterruptedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DDC")]
	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	[Address(RVA = "0x14DD180", Offset = "0x14DC380", Length = "0x47F")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SafeSerializationManager), Member = "CompleteSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000DD5")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14DD600", Offset = "0x14DC800", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000DD0")]
	private string GetStackTrace(bool needFileInfo) { }

	[Address(RVA = "0x14C89F0", Offset = "0x14C7BF0", Length = "0x7")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDB")]
	public override Type GetType() { }

	[Address(RVA = "0x14DD650", Offset = "0x14DC850", Length = "0x92")]
	[CalledBy(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DC6")]
	private void Init() { }

	[Address(RVA = "0x14DD6F0", Offset = "0x14DC8F0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SafeSerializationManager), Member = "CompleteDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[OnDeserialized]
	[Token(Token = "0x6000DD6")]
	private void OnDeserialized(StreamingContext context) { }

	[Address(RVA = "0x14DD780", Offset = "0x14DC980", Length = "0x5")]
	[CalledBy(Type = typeof(OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_unhandled_exception")]
	[Token(Token = "0x6000DDE")]
	internal static void ReportUnhandledException(Exception exception) { }

	[Address(RVA = "0x14DD790", Offset = "0x14DC990", Length = "0xD8")]
	[CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000DD8")]
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DDA")]
	protected void set_HResult(int value) { }

	[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD1")]
	internal void SetErrorCode(int hr) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD7")]
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	[Address(RVA = "0x14DDB40", Offset = "0x14DCD40", Length = "0xF")]
	[CalledBy(Type = typeof(AggregateException), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SecurityException), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000DD3")]
	public virtual string ToString() { }

	[Address(RVA = "0x14DD870", Offset = "0x14DCA70", Length = "0x2C6")]
	[CalledBy(Type = typeof(Exception), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000DD4")]
	private string ToString(bool needFileLineInfo, bool needMessage) { }

}

