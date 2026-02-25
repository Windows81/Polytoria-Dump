namespace Unity.Properties.Internal;

[Token(Token = "0x2000070")]
internal class ColorPropertyBag : ContainerPropertyBag<Color>
{
	[Token(Token = "0x2000074")]
	private class AProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000058")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600027C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000057")]
		public virtual string Name
		{
			[Address(RVA = "0x19F4C20", Offset = "0x19F3E20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600027B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600027F")]
		public AProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F4C20", Offset = "0x19F3E20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600027B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F4BC0", Offset = "0x19F3DC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027D")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x19F4BD0", Offset = "0x19F3DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600027E")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000073")]
	private class BProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000056")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000277")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000055")]
		public virtual string Name
		{
			[Address(RVA = "0x19F4EA0", Offset = "0x19F40A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000276")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F4E60", Offset = "0x19F4060", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600027A")]
		public BProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000277")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F4EA0", Offset = "0x19F40A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000276")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F4E40", Offset = "0x19F4040", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000278")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000279")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000072")]
	private class GProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000054")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000272")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000053")]
		public virtual string Name
		{
			[Address(RVA = "0x19F5B70", Offset = "0x19F4D70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000271")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F5B30", Offset = "0x19F4D30", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000275")]
		public GProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000272")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F5B70", Offset = "0x19F4D70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000271")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5B10", Offset = "0x19F4D10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000273")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000274")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000071")]
	private class RProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000052")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600026D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000051")]
		public virtual string Name
		{
			[Address(RVA = "0x1A133E0", Offset = "0x1A125E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600026C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A133A0", Offset = "0x1A125A0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000270")]
		public RProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A133E0", Offset = "0x1A125E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600026C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026E")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600026F")]
		public virtual void SetValue(ref Color container, float value) { }

	}


	[Address(RVA = "0x19F52A0", Offset = "0x19F44A0", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600026B")]
	public ColorPropertyBag() { }

}

