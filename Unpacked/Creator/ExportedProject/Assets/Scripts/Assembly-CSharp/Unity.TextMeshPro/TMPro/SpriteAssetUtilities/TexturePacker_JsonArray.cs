namespace TMPro.SpriteAssetUtilities;

[Token(Token = "0x20000BC")]
public class TexturePacker_JsonArray
{
	[Token(Token = "0x20000BF")]
	internal struct Frame
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A3")]
		public string filename; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006A4")]
		public SpriteFrame frame; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006A5")]
		public bool rotated; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x40006A6")]
		public bool trimmed; //Field offset: 0x19
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40006A7")]
		public SpriteFrame spriteSourceSize; //Field offset: 0x1C
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40006A8")]
		public SpriteSize sourceSize; //Field offset: 0x2C
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40006A9")]
		public Vector2 pivot; //Field offset: 0x34

	}

	[Token(Token = "0x20000C0")]
	internal struct Meta
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AA")]
		public string app; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006AB")]
		public string version; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006AC")]
		public string image; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006AD")]
		public string format; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006AE")]
		public SpriteSize size; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006AF")]
		public float scale; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006B0")]
		public string smartupdate; //Field offset: 0x30

	}

	[Token(Token = "0x20000C1")]
	internal class SpriteDataObject
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006B1")]
		public List<Frame> frames; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006B2")]
		public Meta meta; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600071B")]
		public SpriteDataObject() { }

	}

	[Token(Token = "0x20000BD")]
	internal struct SpriteFrame
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069D")]
		public float x; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400069E")]
		public float y; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400069F")]
		public float w; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40006A0")]
		public float h; //Field offset: 0xC

		[Address(RVA = "0x18F3560", Offset = "0x18F2760", Length = "0x1C0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000719")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x20000BE")]
	internal struct SpriteSize
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A1")]
		public float w; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006A2")]
		public float h; //Field offset: 0x4

		[Address(RVA = "0x18F3730", Offset = "0x18F2930", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x600071A")]
		public virtual string ToString() { }

	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000718")]
	public TexturePacker_JsonArray() { }

}

