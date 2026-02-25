namespace Unity.Properties.Internal;

[Token(Token = "0x2000081")]
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	[Token(Token = "0x2000082")]
	private class XProperty : Property<Vector2Int, Int32>
	{

		[Token(Token = "0x1700006C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002B2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700006B")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18C80", Offset = "0x1A17E80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002B1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18A50", Offset = "0x1A17C50", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002B5")]
		public XProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18C80", Offset = "0x1A17E80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002B1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A189A0", Offset = "0x1A17BA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B3")]
		public virtual int GetValue(ref Vector2Int container) { }

		[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B4")]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}

	[Token(Token = "0x2000083")]
	private class YProperty : Property<Vector2Int, Int32>
	{

		[Token(Token = "0x1700006E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002B7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700006D")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18F00", Offset = "0x1A18100", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002B6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18E90", Offset = "0x1A18090", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002BA")]
		public YProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18F00", Offset = "0x1A18100", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002B6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A18CE0", Offset = "0x1A17EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B8")]
		public virtual int GetValue(ref Vector2Int container) { }

		[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B9")]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}


	[Address(RVA = "0x1A18110", Offset = "0x1A17310", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002B0")]
	public Vector2IntPropertyBag() { }

}

