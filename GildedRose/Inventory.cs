using System.Collections.Generic;

namespace GildedRose
{
    class Inventory
    {
        private readonly IEnumerable<Item> items;
        public Inventory(IEnumerable<Item> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Items:
        /// "+5 Dexterity Vest"
        /// "Aged Brie"
        /// "Elixir of the Mongoose"
        /// "Sulfuras, Hand of Ragnaros"
        /// "Backstage passes to a TAFKAL80ETC concert"
        /// "Conjured Mana Cake"
        /// </summary>
        /// 



        public void UpdateQuality()
        {
            // TODO ...
            // Hint: Iterate through this.items and check Name property to access specific item
            foreach(var item in items)
            {
                

                if (item.Name.Contains("Aged Brie"))
                {
                    item.SellIn = item.SellIn - 1;
                    item.Quality = item.Quality + 1;

                    if (item.SellIn == -1)
                    {
                        item.Quality = item.Quality - 1;
                    }

                    if (item.Quality <= 0)
                    {
                        item.Quality = 2;
                    }
                }

                    if (item.Name.Contains("Backstage passes"))
                    {
                        item.SellIn = item.SellIn - 1;
                        item.Quality = item.Quality + 1;

                            if(item.SellIn <= 10)
                            {
                                item.Quality = item.Quality + 1;
                            }
                                if (item.SellIn <= 5)
                                {
                                    item.Quality = item.Quality + 1;

                                }
                        if (item.SellIn <= 0)
                        {
                            item.Quality = 0;
                        }
                    }

                        if (item.Name.Contains("Conjured"))
                        {
                            item.SellIn = item.SellIn - 1;
                            item.Quality = item.Quality - 2;

                            if (item.SellIn == -1)
                            {
                                item.Quality = item.Quality - 2;


                            }
                                if (item.Quality <= 0)
                                {
                                    item.Quality = 0;
                                }
                        }

                
                            if (item.Name.Contains("Elixir") || item.Name.Contains("Dexterity Vest"))
                            {
                        
                                item.SellIn = item.SellIn - 1;
                                item.Quality = item.Quality - 1;

                                if (item.SellIn == -1)
                                {
                                    item.Quality = item.Quality - 1;
                                }
                                    if (item.Quality <= 0)
                                    {
                                        item.Quality = 0;
                                    }

                            }
            }
        }
    }
}
