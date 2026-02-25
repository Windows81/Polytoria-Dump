namespace System.Reflection;

[Token(Token = "0x20004F8")]
public abstract class TypeInfo : Type, IReflectableType
{

	[Token(Token = "0x170004B1")]
	public override IEnumerable<Type> ImplementedInterfaces
	{
		[Address(RVA = "0x13CE1D0", Offset = "0x13CD3D0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60022FB")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x13CC560", Offset = "0x13CB760", Length = "0x2D")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022F9")]
	protected TypeInfo() { }

	[Address(RVA = "0x13CE1D0", Offset = "0x13CD3D0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022FB")]
	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022FA")]
	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

