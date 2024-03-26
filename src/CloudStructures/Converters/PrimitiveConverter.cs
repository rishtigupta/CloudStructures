﻿using System;
using StackExchange.Redis;

namespace CloudStructures.Converters;



/// <summary>
/// Provides <see cref="bool"/> conversion function.
/// </summary>
internal sealed class BooleanConverter : IRedisValueConverter<bool>
{
    public RedisValue Serialize(bool value) => value;
    public bool Deserialize(RedisValue value) => (bool)value;
}



/// <summary>
/// Provides <see cref="Nullable{Boolean}"/> conversion function.
/// </summary>
internal sealed class NullableBooleanConverter : IRedisValueConverter<bool?>
{
    public RedisValue Serialize(bool? value) => value;
    public bool? Deserialize(RedisValue value) => (bool?)value;
}



/// <summary>
/// Provides <see cref="char"/> conversion function.
/// </summary>
internal sealed class CharConverter : IRedisValueConverter<char>
{
    public RedisValue Serialize(char value) => (int)value;
    public char Deserialize(RedisValue value) => (char)(int)value;
}



/// <summary>
/// Provides <see cref="Nullable{Char}"/> conversion function.
/// </summary>
internal sealed class NullableCharConverter : IRedisValueConverter<char?>
{
    public RedisValue Serialize(char? value) => (int?)value;
    public char? Deserialize(RedisValue value) => (char?)(int?)value;
}



/// <summary>
/// Provides <see cref="sbyte"/> conversion function.
/// </summary>
internal sealed class SByteConverter : IRedisValueConverter<sbyte>
{
    public RedisValue Serialize(sbyte value) => value;
    public sbyte Deserialize(RedisValue value) => (sbyte)value;
}



/// <summary>
/// Provides <see cref="Nullable{SByte}"/> conversion function.
/// </summary>
internal sealed class NullableSByteConverter : IRedisValueConverter<sbyte?>
{
    public RedisValue Serialize(sbyte? value) => value;
    public sbyte? Deserialize(RedisValue value) => (sbyte?)value;
}



/// <summary>
/// Provides <see cref="byte"/> conversion function.
/// </summary>
internal sealed class ByteConverter : IRedisValueConverter<byte>
{
    public RedisValue Serialize(byte value) => (uint)value;
    public byte Deserialize(RedisValue value) => (byte)(uint)value;
}



/// <summary>
/// Provides <see cref="Nullable{Byte}"/> conversion function.
/// </summary>
internal sealed class NullableByteConverter : IRedisValueConverter<byte?>
{
    public RedisValue Serialize(byte? value) => (uint?)value;
    public byte? Deserialize(RedisValue value) => (byte?)(uint?)value;
}



/// <summary>
/// Provides <see cref="short"/> conversion function.
/// </summary>
internal sealed class Int16Converter : IRedisValueConverter<short>
{
    public RedisValue Serialize(short value) => value;
    public short Deserialize(RedisValue value) => (short)value;
}



/// <summary>
/// Provides <see cref="Nullable{Int16}"/> conversion function.
/// </summary>
internal sealed class NullableInt16Converter : IRedisValueConverter<short?>
{
    public RedisValue Serialize(short? value) => value;
    public short? Deserialize(RedisValue value) => (short?)value;
}



/// <summary>
/// Provides <see cref="ushort"/> conversion function.
/// </summary>
internal sealed class UInt16Converter : IRedisValueConverter<ushort>
{
    public RedisValue Serialize(ushort value) => (uint)value;
    public ushort Deserialize(RedisValue value) => (ushort)(uint)value;
}



/// <summary>
/// Provides <see cref="Nullable{UInt16}"/> conversion function.
/// </summary>
internal sealed class NullableUInt16Converter : IRedisValueConverter<ushort?>
{
    public RedisValue Serialize(ushort? value) => (uint?)value;
    public ushort? Deserialize(RedisValue value) => (ushort?)(uint?)value;
}



/// <summary>
/// Provides <see cref="int"/> conversion function.
/// </summary>
internal sealed class Int32Converter : IRedisValueConverter<int>
{
    public RedisValue Serialize(int value) => value;
    public int Deserialize(RedisValue value) => (int)value;
}



/// <summary>
/// Provides <see cref="Nullable{Int32}"/> conversion function.
/// </summary>
internal sealed class NullableInt32Converter : IRedisValueConverter<int?>
{
    public RedisValue Serialize(int? value) => value;
    public int? Deserialize(RedisValue value) => (int?)value;
}



/// <summary>
/// Provides <see cref="uint"/> conversion function.
/// </summary>
internal sealed class UInt32Converter : IRedisValueConverter<uint>
{
    public RedisValue Serialize(uint value) => value;
    public uint Deserialize(RedisValue value) => (uint)value;
}



/// <summary>
/// Provides <see cref="Nullable{UInt32}"/> conversion function.
/// </summary>
internal sealed class NullableUInt32Converter : IRedisValueConverter<uint?>
{
    public RedisValue Serialize(uint? value) => value;
    public uint? Deserialize(RedisValue value) => (uint?)value;
}



/// <summary>
/// Provides <see cref="long"/> conversion function.
/// </summary>
internal sealed class Int64Converter : IRedisValueConverter<long>
{
    public RedisValue Serialize(long value) => value;
    public long Deserialize(RedisValue value) => (long)value;
}



/// <summary>
/// Provides <see cref="Nullable{Int64}"/> conversion function.
/// </summary>
internal sealed class NullableInt64Converter : IRedisValueConverter<long?>
{
    public RedisValue Serialize(long? value) => value;
    public long? Deserialize(RedisValue value) => (long?)value;
}



/// <summary>
/// Provides <see cref="ulong"/> conversion function.
/// </summary>
internal sealed class UInt64Converter : IRedisValueConverter<ulong>
{
    public RedisValue Serialize(ulong value) => value;
    public ulong Deserialize(RedisValue value) => (ulong)value;
}



/// <summary>
/// Provides <see cref="Nullable{UInt64}"/> conversion function.
/// </summary>
internal sealed class NullableUInt64Converter : IRedisValueConverter<ulong?>
{
    public RedisValue Serialize(ulong? value) => value;
    public ulong? Deserialize(RedisValue value) => (ulong?)value;
}



/// <summary>
/// Provides <see cref="float"/> conversion function.
/// </summary>
internal sealed class SingleConverter : IRedisValueConverter<float>
{
    public RedisValue Serialize(float value) => value;
    public float Deserialize(RedisValue value) => (float)value;
}



/// <summary>
/// Provides <see cref="Nullable{Single}"/> conversion function.
/// </summary>
internal sealed class NullableSingleConverter : IRedisValueConverter<float?>
{
    public RedisValue Serialize(float? value) => value;
    public float? Deserialize(RedisValue value) => (float?)value;
}



/// <summary>
/// Provides <see cref="double"/> conversion function.
/// </summary>
internal sealed class DoubleConverter : IRedisValueConverter<double>
{
    public RedisValue Serialize(double value) => value;
    public double Deserialize(RedisValue value) => (double)value;
}



/// <summary>
/// Provides <see cref="Nullable{Double}"/> conversion function.
/// </summary>
internal sealed class NullableDoubleConverter : IRedisValueConverter<double?>
{
    public RedisValue Serialize(double? value) => value;
    public double? Deserialize(RedisValue value) => (double?)value;
}



/// <summary>
/// Provides <see cref="string"/> conversion function.
/// </summary>
internal sealed class StringConverter : IRedisValueConverter<string>
{
    public RedisValue Serialize(string value) => value;
    public string Deserialize(RedisValue value) => value;
}



/// <summary>
/// Provides <see cref="byte"/>[] conversion function.
/// </summary>
internal sealed class ByteArrayConverter : IRedisValueConverter<byte[]>
{
    public RedisValue Serialize(byte[] value) => value;
    public byte[] Deserialize(RedisValue value) => value;
}



/// <summary>
/// Provides <see cref="Memory{T}"/> (= T is <see cref="byte"/>) conversion function.
/// </summary>
internal sealed class MemoryByteConverter : IRedisValueConverter<Memory<byte>>
{
    public RedisValue Serialize(Memory<byte> value) => value;
    public Memory<byte> Deserialize(RedisValue value) => (byte[])value;
}



/// <summary>
/// Provides <see cref="ReadOnlyMemory{T}"/> (= T is <see cref="byte"/>) conversion function.
/// </summary>
internal sealed class ReadOnlyMemoryByteConverter : IRedisValueConverter<ReadOnlyMemory<byte>>
{
    public RedisValue Serialize(ReadOnlyMemory<byte> value) => value;
    public ReadOnlyMemory<byte> Deserialize(RedisValue value) => value;
}
