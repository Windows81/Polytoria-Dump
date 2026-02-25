namespace Unity.Properties.Internal;

[Token(Token = "0x2000098")]
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
{
	[Token(Token = "0x200009B")]
	private class BuildProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000092")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000318")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000091")]
		public virtual string Name
		{
			[Address(RVA = "0x19F51C0", Offset = "0x19F43C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000317")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F5130", Offset = "0x19F4330", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000316")]
		public BuildProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000318")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F51C0", Offset = "0x19F43C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000317")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5110", Offset = "0x19F4310", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000319")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031A")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x2000099")]
	private class MajorProperty : Property<Version, Int32>
	{

		[Token(Token = "0x1700008E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x600030E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008D")]
		public virtual string Name
		{
			[Address(RVA = "0x19F6090", Offset = "0x19F5290", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600030D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F6000", Offset = "0x19F5200", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600030C")]
		public MajorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F6090", Offset = "0x19F5290", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600030D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5FE0", Offset = "0x19F51E0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600030F")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000310")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x200009A")]
	private class MinorProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000090")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000313")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008F")]
		public virtual string Name
		{
			[Address(RVA = "0x19F6170", Offset = "0x19F5370", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000312")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F60E0", Offset = "0x19F52E0", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000311")]
		public MinorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000313")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F6170", Offset = "0x19F5370", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000312")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F60C0", Offset = "0x19F52C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000314")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000315")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x200009C")]
	private class RevisionProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000094")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x600031D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000093")]
		public virtual string Name
		{
			[Address(RVA = "0x1A141B0", Offset = "0x1A133B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600031C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A14120", Offset = "0x1A13320", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600031B")]
		public RevisionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A141B0", Offset = "0x1A133B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600031C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A14100", Offset = "0x1A13300", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600031E")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031F")]
		public virtual void SetValue(ref Version container, int value) { }

	}


	[Address(RVA = "0x1A14250", Offset = "0x1A13450", Length = "0x2F5")]
	[CalledBy(Type = typeof(PropertiesInitialization), Member = "InitializeProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Unity.Properties.Property`2<System.Object, System.Int32>), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600030B")]
	public SystemVersionPropertyBag() { }

}

