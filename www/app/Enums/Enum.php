<?php
namespace App\Enums;
use ReflectionClass;
abstract class Enum
{
    private static $constCacheArray = null;
    private static function getConstants(): array
    {
        if (self::$constCacheArray == null) {
            self::$constCacheArray = [];
        }
        $calledClass = get_called_class();
        if (!array_key_exists($calledClass, self::$constCacheArray)) {
            $reflect = new ReflectionClass($calledClass);
            self::$constCacheArray[$calledClass] = $reflect->getConstants();
        }
        return self::$constCacheArray[$calledClass];
    }
    public static function getKeys(): array
    {
        return array_keys(self::getConstants());
    }
    public static function getSelect()
    {
        return array_map(function($value) {
            return str_replace("_"," ",$value);
        }, array_flip(self::getConstants()));
    }
    public static function getValues(): array
    {
        return array_values(self::getConstants());
    }
    public static function getKey(int $value): string
    {
        return str_replace("_"," ", array_search($value, self::getConstants()));
    }
    public static function getValue(string $key): int
    {
        return self::getConstants()[$key];
    }
    public static function getDescription(int $value): string
    {
        return self::getKey($value);
    }
    public static function getRandomKey(): string
    {
        $keys = self::getKeys();
        return $keys[array_rand($keys, 1)];
    }
    public static function getRandomValue(): string
    {
        $values = self::getValues();
        return $values[array_rand($values, 1)];
    }
}