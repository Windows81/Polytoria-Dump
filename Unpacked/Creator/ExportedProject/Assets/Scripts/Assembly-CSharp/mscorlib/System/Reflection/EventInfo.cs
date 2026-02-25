namespace System.Reflection;

[Token(Token = "0x20004CE")]
public abstract class EventInfo : MemberInfo
{
	[Token(Token = "0x20004CF")]
	private sealed class AddEventAdapter : MulticastDelegate
	{

		[Address(RVA = "0x335350", Offset = "0x334550", Length = "0x125")]
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002171")]
		public AddEventAdapter(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002172")]
		public override void Invoke(object _this, Delegate dele) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400131D")]
	private AddEventAdapter cached_add_event; //Field offset: 0x10

	[Token(Token = "0x1700041D")]
	public abstract EventAttributes Attributes
	{
		[Token(Token = "0x6002165")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700041F")]
	public override Type EventHandlerType
	{
		[Address(RVA = "0x13B7FE0", Offset = "0x13B71E0", Length = "0x131")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600216A")]
		 get { } //Length: 305
	}

	[Token(Token = "0x1700041E")]
	public override bool IsSpecialName
	{
		[Address(RVA = "0x13B8120", Offset = "0x13B7320", Length = "0x24")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002166")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700041C")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002164")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002163")]
	protected EventInfo() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600216B")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6002165")]
	public abstract EventAttributes get_Attributes() { }

	[Address(RVA = "0x13B7FE0", Offset = "0x13B71E0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600216A")]
	public override Type get_EventHandlerType() { }

	[Address(RVA = "0x13B8120", Offset = "0x13B7320", Length = "0x24")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002166")]
	public override bool get_IsSpecialName() { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002164")]
	public virtual MemberTypes get_MemberType() { }

	[Token(Token = "0x6002167")]
	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	[Address(RVA = "0x13B7F30", Offset = "0x13B7130", Length = "0xAC")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002170")]
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600216C")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6002169")]
	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	[Token(Token = "0x6002168")]
	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	[Address(RVA = "0x13B8150", Offset = "0x13B7350", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9E0")]
	[Token(Token = "0x600216F")]
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600216D")]
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	[Address(RVA = "0x13B8160", Offset = "0x13B7360", Length = "0x3E")]
	[CallerCount(Count = 129)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600216E")]
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

}

