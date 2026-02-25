namespace Unity.Properties.Internal;

[Token(Token = "0x2000075")]
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
{
	[Token(Token = "0x2000076")]
	private class XProperty : Property<Vector2, Single>
	{

		[Token(Token = "0x1700005A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000282")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000059")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18B90", Offset = "0x1A17D90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000281")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A189D0", Offset = "0x1A17BD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000285")]
		public XProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000282")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18B90", Offset = "0x1A17D90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000281")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000283")]
		public virtual float GetValue(ref Vector2 container) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000284")]
		public virtual void SetValue(ref Vector2 container, float value) { }

	}

	[Token(Token = "0x2000077")]
	private class YProperty : Property<Vector2, Single>
	{

		[Token(Token = "0x1700005C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000287")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700005B")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18FC0", Offset = "0x1A181C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000286")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18E50", Offset = "0x1A18050", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600028A")]
		public YProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000287")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18FC0", Offset = "0x1A181C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000286")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5B10", Offset = "0x19F4D10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000288")]
		public virtual float GetValue(ref Vector2 container) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000289")]
		public virtual void SetValue(ref Vector2 container, float value) { }

	}


	[Address(RVA = "0x1A18230", Offset = "0x1A17430", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000280")]
	public Vector2PropertyBag() { }

}

