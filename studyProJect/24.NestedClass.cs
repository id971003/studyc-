using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    중첩 클래스
    클레스에 클레스를 중첩시켜 선언한다.
    자신이 속해 있는 클래스의 멤버에 자유롭게 접근가능 

    사용이유 : 클레스를 외부에 공개하고 싶지 않을때 , 현재의 클래스를 일부분 처럼 표현 하고 싶을때

    ?은닉성이 무너지지만 더 유연해진다 ?
     */


    class NestedClass
    {
        public static void NestedClassTestClass()
        {
            Configuration Config = new Configuration();

            Config.SetConfig("Version", "V5");
            Config.SetConfig("Size", "51KB");
            Console.WriteLine(Config.GetConfig("Version"));
            Console.WriteLine(Config.GetConfig("Size"));
        }
    }
    class Configuration
    {
        List<ItemValue> ListConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue Iv = new ItemValue();
            Iv.SetValue(this, item, value);
        }
        public string GetConfig(string item)
        {
            foreach (ItemValue iv in ListConfig)
            {
                if (iv.GetItem() == item)
                {
                    return iv.GetValue();
                }
            }
            return "오류";
        }


        private class ItemValue
        {
            private string Item;
            private string Value;

            public void SetValue(Configuration config, string item, string vaule)
            {
                this.Item = item;
                this.Value = vaule;

                bool found = false;

                for (int i = 0; i < config.ListConfig.Count; i++) // 상위 클레스의 필드에 접근 
                {
                    if (config.ListConfig[i].Item == item)
                    {
                        config.ListConfig[i] = this;
                        found = true;
                        break;
                    }
                }
                if (!found)
                    config.ListConfig.Add(this);



            }
            public string GetItem()
            {
                return Item;
            }
            public string GetValue()
            {
                return Value;
            }
        }
    }
}