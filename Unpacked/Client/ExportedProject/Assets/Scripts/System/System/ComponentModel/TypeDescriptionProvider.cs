namespace System.ComponentModel;

[Token(Token = "0x200017B")]
public abstract class TypeDescriptionProvider
{
	[Token(Token = "0x200017C")]
	private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000931")]
		public EmptyCustomTypeDescriptor() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000620")]
	private readonly TypeDescriptionProvider _parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000621")]
	private EmptyCustomTypeDescriptor _emptyDescriptor; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000929")]
	protected TypeDescriptionProvider() { }

	[Address(RVA = "0x17AABF0", Offset = "0x17A9DF0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092A")]
	public override IDictionary GetCache(object instance) { }

	[Address(RVA = "0x17AAC10", Offset = "0x17A9E10", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092B")]
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x17AACF0", Offset = "0x17A9EF0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092C")]
	public Type GetReflectionType(Type objectType) { }

	[Address(RVA = "0x17AACC0", Offset = "0x17A9EC0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092D")]
	public override Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x17AAE60", Offset = "0x17AA060", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092E")]
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	[Address(RVA = "0x17AADD0", Offset = "0x17A9FD0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600092F")]
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	[Address(RVA = "0x17AAD10", Offset = "0x17A9F10", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000930")]
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

