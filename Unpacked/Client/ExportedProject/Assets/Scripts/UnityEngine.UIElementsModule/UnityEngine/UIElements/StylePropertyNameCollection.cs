namespace UnityEngine.UIElements;

[Token(Token = "0x2000236")]
public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	[Token(Token = "0x2000237")]
	internal struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008C4")]
		private Enumerator<StylePropertyName> m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x170002CB")]
		public override StylePropertyName Current
		{
			[Address(RVA = "0x1C4C660", Offset = "0x1C4B860", Length = "0x41")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6000F62")]
			 get { } //Length: 65
		}

		[Token(Token = "0x170002CC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1C4C5D0", Offset = "0x1C4B7D0", Length = "0x61")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x6000F63")]
			private get { } //Length: 97
		}

		[Address(RVA = "0x1C4C640", Offset = "0x1C4B840", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000F60")]
		internal Enumerator(Enumerator<StylePropertyName> enumerator) { }

		[Address(RVA = "0x1C4C550", Offset = "0x1C4B750", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F65")]
		public override void Dispose() { }

		[Address(RVA = "0x1C4C660", Offset = "0x1C4B860", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000F62")]
		public override StylePropertyName get_Current() { }

		[Address(RVA = "0x1C4C590", Offset = "0x1C4B790", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Token(Token = "0x6000F61")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F64")]
		public override void Reset() { }

		[Address(RVA = "0x1C4C5D0", Offset = "0x1C4B7D0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x6000F63")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C3")]
	internal List<StylePropertyName> propertiesList; //Field offset: 0x0

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F5C")]
	internal StylePropertyNameCollection(List<StylePropertyName> list) { }

	[Address(RVA = "0x1C5D730", Offset = "0x1C5C930", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F5D")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x1C5D7D0", Offset = "0x1C5C9D0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F5E")]
	private override IEnumerator<StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	[Address(RVA = "0x1C5D890", Offset = "0x1C5CA90", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F5F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

