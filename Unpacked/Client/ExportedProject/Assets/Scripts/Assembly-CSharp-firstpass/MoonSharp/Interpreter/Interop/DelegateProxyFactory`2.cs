namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000DB")]
public class DelegateProxyFactory : IProxyFactory<TProxy, TTarget>, IProxyFactory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003A1")]
	private Func<TTarget, TProxy> wrapDelegate; //Field offset: 0x0

	[Token(Token = "0x17000125")]
	public override Type ProxyType
	{
		[Address(RVA = "0x9E75C0", Offset = "0x9E67C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D8")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000124")]
	public override Type TargetType
	{
		[Address(RVA = "0x9E7600", Offset = "0x9E6800", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D7")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D4")]
	public DelegateProxyFactory`2(Func<TTarget, TProxy> wrapDelegate) { }

	[Address(RVA = "0x9E7590", Offset = "0x9E6790", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D5")]
	public override TProxy CreateProxyObject(TTarget target) { }

	[Address(RVA = "0x9E7500", Offset = "0x9E6700", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D6")]
	public override object CreateProxyObject(object o) { }

	[Address(RVA = "0x9E75C0", Offset = "0x9E67C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D8")]
	public override Type get_ProxyType() { }

	[Address(RVA = "0x9E7600", Offset = "0x9E6800", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D7")]
	public override Type get_TargetType() { }

}

