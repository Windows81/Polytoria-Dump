namespace Unity.Properties.Internal;

[Token(Token = "0x2000088")]
internal class RectPropertyBag : ContainerPropertyBag<Rect>
{
	[Token(Token = "0x200008C")]
	private class HeightProperty : Property<Rect, Single>
	{

		[Token(Token = "0x1700007C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002DC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007B")]
		public virtual string Name
		{
			[Address(RVA = "0x19F5FB0", Offset = "0x19F51B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002DB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F5F00", Offset = "0x19F5100", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002DF")]
		public HeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F5FB0", Offset = "0x19F51B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002DB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5EE0", Offset = "0x19F50E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DD")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x19F4BD0", Offset = "0x19F3DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DE")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x200008B")]
	private class WidthProperty : Property<Rect, Single>
	{

		[Token(Token = "0x1700007A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002D7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000079")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18940", Offset = "0x1A17B40", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002D6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18900", Offset = "0x1A17B00", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002DA")]
		public WidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18940", Offset = "0x1A17B40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002D6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A18890", Offset = "0x1A17A90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D8")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D9")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x2000089")]
	private class XProperty : Property<Rect, Single>
	{

		[Token(Token = "0x17000076")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002CD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000075")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18C20", Offset = "0x1A17E20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002CC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18AD0", Offset = "0x1A17CD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002D0")]
		public XProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18C20", Offset = "0x1A17E20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002CC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A189B0", Offset = "0x1A17BB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CF")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x200008A")]
	private class YProperty : Property<Rect, Single>
	{

		[Token(Token = "0x17000078")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002D2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000077")]
		public virtual string Name
		{
			[Address(RVA = "0x1A18F90", Offset = "0x1A18190", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002D1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1A18D10", Offset = "0x1A17F10", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002D5")]
		public YProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1A18F90", Offset = "0x1A18190", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002D1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1A18CF0", Offset = "0x1A17EF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D3")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D4")]
		public virtual void SetValue(ref Rect container, float value) { }

	}


	[Address(RVA = "0x1A135E0", Offset = "0x1A127E0", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60002CB")]
	public RectPropertyBag() { }

}

