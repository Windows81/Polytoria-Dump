namespace Unity.Properties.Internal;

[Token(Token = "0x2000095")]
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	[Token(Token = "0x2000096")]
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{

		[Token(Token = "0x1700008A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000302")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000089")]
		public virtual string Name
		{
			[Address(RVA = "0x19F64A0", Offset = "0x19F56A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000301")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F6460", Offset = "0x19F5660", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000305")]
		public PositionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000302")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F64A0", Offset = "0x19F56A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000301")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F51F0", Offset = "0x19F43F0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000303")]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[Address(RVA = "0x19F5210", Offset = "0x19F4410", Length = "0x11")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000304")]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}

	[Token(Token = "0x2000097")]
	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{

		[Token(Token = "0x1700008C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000307")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008B")]
		public virtual string Name
		{
			[Address(RVA = "0x1A14220", Offset = "0x1A13420", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000306")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A141E0", Offset = "0x1A133E0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600030A")]
		public SizeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000307")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A14220", Offset = "0x1A13420", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000306")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5980", Offset = "0x19F4B80", Length = "0x17")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000308")]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[Address(RVA = "0x19F59A0", Offset = "0x19F4BA0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000309")]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}


	[Address(RVA = "0x19F4ED0", Offset = "0x19F40D0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000300")]
	public BoundsIntPropertyBag() { }

}

