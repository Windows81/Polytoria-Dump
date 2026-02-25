namespace System.Diagnostics;

[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with .NET")]
[Token(Token = "0x2000580")]
public class StackTrace
{
	[Token(Token = "0x2000581")]
	public enum TraceFormat
	{
		Normal = 0,
		TrailingNewLine = 1,
		NoResourceLookup = 2,
	}

	[Token(Token = "0x4001773")]
	private static bool isAotidSet; //Field offset: 0x0
	[Token(Token = "0x4001774")]
	private static string aotid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001770")]
	private StackFrame[] frames; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001771")]
	private readonly StackTrace[] captured_traces; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001772")]
	private bool debug_info; //Field offset: 0x20

	[Token(Token = "0x17000610")]
	public override int FrameCount
	{
		[Address(RVA = "0x144B830", Offset = "0x144AA30", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002849")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x144B800", Offset = "0x144AA00", Length = "0x25")]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002842")]
	public StackTrace() { }

	[Address(RVA = "0x144B5B0", Offset = "0x144A7B0", Length = "0x32")]
	[CalledBy(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterface", Member = "get_FixedInfo", ReturnType = "System.Net.NetworkInformation.Win32_FIXED_INFO")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002843")]
	public StackTrace(bool fNeedFileInfo) { }

	[Address(RVA = "0x144B710", Offset = "0x144A910", Length = "0x3F")]
	[CalledBy(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStringFromExceptionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002844")]
	public StackTrace(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x144B750", Offset = "0x144A950", Length = "0xAB")]
	[CalledBy(Type = typeof(Exception), Member = "get_Source", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802122A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002847")]
	public StackTrace(Exception e, bool fNeedFileInfo) { }

	[Address(RVA = "0x144B5F0", Offset = "0x144A7F0", Length = "0x11B")]
	[CalledBy(Type = typeof(ExceptionDispatchInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802122A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002848")]
	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x144A3F0", Offset = "0x14495F0", Length = "0x507")]
	[CalledBy(Type = typeof(StackTrace), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StackFrame), Member = "GetSecureFileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MethodBase), typeof(bool), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600284C")]
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	[Address(RVA = "0x144A900", Offset = "0x1449B00", Length = "0x2D8")]
	[CalledBy(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MethodBase), typeof(bool), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600284E")]
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	[Address(RVA = "0x144B830", Offset = "0x144AA30", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002849")]
	public override int get_FrameCount() { }

	[Address(RVA = "0x144B850", Offset = "0x144AA50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802122A0")]
	[Token(Token = "0x6002846")]
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x144ABE0", Offset = "0x1449DE0", Length = "0xE2")]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeAssembly), Member = "GetAotId", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600284B")]
	private static string GetAotId() { }

	[Address(RVA = "0x144ACD0", Offset = "0x1449ED0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600284A")]
	public override StackFrame GetFrame(int index) { }

	[Address(RVA = "0x144AD40", Offset = "0x1449F40", Length = "0x6C5")]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StackTrace), Member = "ConvertAsyncStateMachineMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase&), typeof(Type&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 22)]
	[Token(Token = "0x600284D")]
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	[Address(RVA = "0x144B860", Offset = "0x144AA60", Length = "0x233")]
	[CalledBy(Type = typeof(StackTrace), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002845")]
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	[Address(RVA = "0x144B410", Offset = "0x144A610", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600284F")]
	public virtual string ToString() { }

	[Address(RVA = "0x144B590", Offset = "0x144A790", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002850")]
	internal string ToString(TraceFormat traceFormat) { }

}

