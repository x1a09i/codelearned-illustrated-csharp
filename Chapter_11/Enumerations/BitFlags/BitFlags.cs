using System;

namespace BitFlags
{
    // 此处使用Flags特性，告诉编译器该枚举类型需要进行特殊对待
    [Flags]
    // 定义时显式地指定底层整数类型，可以节约内存
    enum CardDeckSettings : uint
    {
        // 基本语法：各个成员用逗号分隔，没有分号作为结束
        SingleDeck    = 0x01,
        LargePictures = 0x02,
        FancyNumbers  = 0x04,
        Animation     = 0x08
    }

   class CardDeckStatus
    {
        bool UseSingleDeck               = false,
             UseBigPics                  = false,
             UseFancyNumbers             = false,
             UseAnimation                = false,
             UseAnimationAndFancyNumbers = false;

        public void SetOptions(CardDeckSettings ops)
        {
            UseSingleDeck               = ops.HasFlag(CardDeckSettings.SingleDeck);
            UseBigPics                  = ops.HasFlag(CardDeckSettings.LargePictures);
            UseFancyNumbers             = ops.HasFlag(CardDeckSettings.FancyNumbers);
            UseAnimation                = ops.HasFlag(CardDeckSettings.Animation);

            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
            UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
        }

        public void PrintOptions()
        {
            Console.WriteLine("Option settings:");
            Console.WriteLine(" Use Single Deck - {0}", UseSingleDeck);
            Console.WriteLine(" Use Large Pictures - {0}", UseBigPics);
            Console.WriteLine(" Use Fancy Numbers - {0}", UseFancyNumbers);
            Console.WriteLine(" Show Animation - {0}", UseAnimation);
            Console.WriteLine(" Show Animation and FancyNumbers - {0}", UseAnimationAndFancyNumbers);
        }
    }

    class BitFlags
    {
        static void Main(string[] args)
        {
            CardDeckStatus deckStat = new CardDeckStatus();
            CardDeckSettings ops = CardDeckSettings.SingleDeck
                | CardDeckSettings.FancyNumbers
                | CardDeckSettings.Animation;

            deckStat.SetOptions(ops);
            deckStat.PrintOptions();

            Console.ReadKey();
        }
    }
}
