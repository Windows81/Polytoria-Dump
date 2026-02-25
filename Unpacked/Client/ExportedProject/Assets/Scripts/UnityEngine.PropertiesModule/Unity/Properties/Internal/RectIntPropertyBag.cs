namespace Unity.Properties.Internal;

[Token(Token = "0x200008D")]
internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
{
	[Token(Token = "0x2000091")]
	private class HeightProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000084")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002F1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000083")]
		public virtual string Name
		{
			[Address(RVA = "0x19F5F80", Offset = "0x19F5180", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002F0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F5F40", Offset = "0x19F5140", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002F4")]
		public HeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F5F80", Offset = "0x19F5180", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002F0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5ED0", Offset = "0x19F50D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F2")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x19F5EF0", Offset = "0x19F50F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F3")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x2000090")]
	private class WidthProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000082")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002EC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000081")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18970", Offset = "0x1A17B70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002EB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A188C0", Offset = "0x1A17AC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002EF")]
		public WidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18970", Offset = "0x1A17B70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002EB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A188A0", Offset = "0x1A17AA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002ED")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x1A188B0", Offset = "0x1A17AB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EE")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x200008E")]
	private class XProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x1700007E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002E2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007D")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18CB0", Offset = "0x1A17EB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002E1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18B50", Offset = "0x1A17D50", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002E5")]
		public XProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18CB0", Offset = "0x1A17EB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002E1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A189A0", Offset = "0x1A17BA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E3")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E4")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x200008F")]
	private class YProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000080")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002E7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007F")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18F30", Offset = "0x1A18130", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002E6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18E10", Offset = "0x1A18010", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002EA")]
		public YProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18F30", Offset = "0x1A18130", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002E6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A18CE0", Offset = "0x1A17EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E8")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E9")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}


	[Address(RVA = "0x1A13410", Offset = "0x1A12610", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60002E0")]
	public RectIntPropertyBag() { }

}

