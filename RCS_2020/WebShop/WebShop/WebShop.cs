using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class WebShop
    {
        #region Properties & Fields

        //Name - ir read-only property, var tikai lasīt
        //līdz ar to vērtību var mainīt tikai caur _name
        private string _name;
        public string Name { get { return _name; } }

        //labs stils ir publiskās īpašības veidot kā property,
        //taču Address ir atstāts kā piemērs
        public string Address; //šis pieraksts FUNKCIONĀLI ir tāds pats kā ar { get;set; }

        //auto-property, jeb tehniski tāds pats kā Address
        //un "under the hood" tāds pats kā WebAddress
        public int Anno { get; set; }

        //WebAddress piemērs kā izskatās noklusēts auto-property no funkcionālās puses
        private string _webAddress;
        public string WebAddress
        {
            get
            {
                return _webAddress;
            }
            set
            {
                _webAddress = value;
            }
        }

        private string _warehouseAddress;
        public string WarehouseAddress
        {
            get
            {
                if (string.IsNullOrEmpty(_warehouseAddress))
                {
                    return "ERROR:Noliktavas adrese nav norādīta!";
                }

                return _warehouseAddress;
            }
            set
            {
                //value - topošā vērtība, kuru vēlamies uzstādīt
                //jeb vērtība pēc = zīmes, kuru padodam izsaukumā kā:
                //WarehouseAddress = "VĒRTĪBAS TEKSTS";
                if (string.IsNullOrEmpty(value))
                {
                    _warehouseAddress = "DEFAULT_NOLIKTAVAS_ADRESE";
                }
                else
                {
                    _warehouseAddress = value;
                }
            }
        }

        //īpašību var tikai nolasīt, to nevar uzstādīt
        public string FullAddress
        {
            get
            {
                return "Biroja adrese: " + Address +
                  ", Noliktavas adrese: " + WarehouseAddress;
            }
        }

        //_shopItemList piešķiram noklusēto/sākotnējo vērtību - jauns saraksts
        private List<ShopItem> _shopItemList = new List<ShopItem>();

        //static - izveido mainīgo, kurš ir pieejams darbam tikai BEZ klases objekta instances
        public static int IzveidotoObjektuSkaits = 0;

        #endregion

        #region Constructors

        //konstruktors - objekta inicializācijas sākuma punkts
        public WebShop()
        {
            Console.WriteLine("Tiek izveidots WebShop objekts!");
            IzveidotoObjektuSkaits++;
        }

        public WebShop(string name)
        {
            Console.WriteLine("Tiek izveidots WebShop objekts ar nosaukumu!");
            _name = name;
            IzveidotoObjektuSkaits++;
        }

        public WebShop(string name, int anno)
        {
            Console.WriteLine("Tiek izveidots WebShop objekts ar nosaukumu un dibināšanas gadu!");
            _name = name;
            Anno = anno;
            IzveidotoObjektuSkaits++;
        }

        #endregion

        #region Methods

        public void PrintInfo()
        {
            Console.WriteLine($"Esiet sveicināti interneta veikalā {Name}");
            Console.WriteLine("Interneta veikala info: " +
                $"pilna adrese: {FullAddress}," +
                $"anno: {Anno}," +
                $"web adrese: {WebAddress}.");
        }

        public void PrintItemsInfo()
        {
            if (_shopItemList.Count > 0)
            {
                foreach (var item in _shopItemList)
                {
                    item.PrintInfo();
                }
            }
        }

        public void AddNewItem(ShopItem item)
        {
            if (ValidateShopItem(item))
            {
                _shopItemList.Add(item);
            }
        }

        //Validācijas metode
        private bool ValidateShopItem(ShopItem item)
        {
            if (item.Count < 1 || string.IsNullOrEmpty(item.Name) || item.Id == 0)
            {
                return false;
            }

            return true;
        }

        //static - šis elements (piemērā metode) ir pieejams izmantojot klasi bez objekta
        public static void PrintTutorial()
        {
            Console.WriteLine("Klase WebShop satur informāciju par interneta veikalu un tā precēm!");
            Console.WriteLine($"Līdz šim ir izveidoti {IzveidotoObjektuSkaits} veikali!");
        }

        #endregion
    }
}
