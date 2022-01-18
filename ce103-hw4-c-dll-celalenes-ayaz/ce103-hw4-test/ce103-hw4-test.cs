using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class ce103_hw4_test
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test1()
        {
            ce103fonksiyon sonuc = new ce103fonksiyon();
            int resuwe = sonuc.ce103_fibonacciNumber_cs(2);

            Assert.AreEqual(resuwe, 2);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_test2()
        {
            ce103fonksiyon sonuc = new ce103fonksiyon();
            int resuwe = sonuc.ce103_fibonacciNumber_cs(23);

            Assert.AreEqual(resuwe, 46368);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_test3()
        {
            ce103fonksiyon sonuc = new ce103fonksiyon();
            int resuwe = sonuc.ce103_fibonacciNumber_cs(25);

            Assert.AreEqual(resuwe, 121393);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_cs_test1()
        {
            ce103CsFunctions sonuc = new ce103CsFunctions();
            int resuwe = sonuc.ce103_fibonacciNumber_cs_cs(35);

            Assert.AreEqual(resuwe, 9227465);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_cs_test2()
        {
            ce103CsFunctions sonuc = new ce103CsFunctions();
            int resuwe = sonuc.ce103_fibonacciNumber_cs_cs(41);

            Assert.AreEqual(resuwe, 165580141);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_cs_test3()
        {
            ce103CsFunctions sonuc = new ce103CsFunctions();
            int resuwe = sonuc.ce103_fibonacciNumber_cs_cs(39);

            Assert.AreEqual(resuwe, 63245986);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cscs_test1()
        {
            ce103CsFunctions cscsdegeree = new ce103CsFunctions();
            ce103fonksiyon csdegeree = new ce103fonksiyon();
            int csee = csdegeree.ce103_fibonacciNumber_cs(21);
            int cscsee = cscsdegeree.ce103_fibonacciNumber_cs_cs(22);

            Assert.AreEqual(csee, cscsee);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cscs_test2()
        {
            ce103CsFunctions cscsdegeree = new ce103CsFunctions();
            ce103fonksiyon csdegeree = new ce103fonksiyon();
            int csee = csdegeree.ce103_fibonacciNumber_cs(22);
            int cscsee = cscsdegeree.ce103_fibonacciNumber_cs_cs(23);

            Assert.AreEqual(csee, cscsee);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_cs_vs_cscs_test3()
        {
            ce103CsFunctions cscsdegeree = new ce103CsFunctions();
            ce103fonksiyon csdegeree = new ce103fonksiyon();
            int csee = csdegeree.ce103_fibonacciNumber_cs(33);
            int cscsee = cscsdegeree.ce103_fibonacciNumber_cs_cs(34);

            Assert.AreEqual(csee, cscsee);
        }

        [TestMethod]
        public void ce103_strrev_cs_test1()
        {

            ce103fonksiyon revrsee = new ce103fonksiyon();

            string origine = "HelloClass";
            string revae = "ssalColleH";

            Assert.AreEqual(revrsee.ce103_strrev_cs(origine), revae);

        }


        [TestMethod]
        public void ce103_strrev_cs_test2()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon revrseee = new ce103fonksiyon();

            string originee = "celal";
            string reveee = "lalec";

            Assert.AreEqual(revrseee.ce103_strrev_cs(originee), reveee);
        }

        [TestMethod]
        public void ce103_strrev_cs_test3()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon revrseee = new ce103fonksiyon();

            string originee = "meze";
            string reveee = "ezem";

            Assert.AreEqual(revrseee.ce103_strrev_cs(originee), reveee);
        }

        [TestMethod]
        public void ce103_strrev_cs_cs_test1()
        {
            ce103CsFunctions revrseee = new ce103CsFunctions();
            string originee = "students";
            string reveee = "stneduts";
            Assert.AreEqual(revrseee.ce103_strrev_cs_cs(originee), reveee);
        }

        [TestMethod]
        public void ce103_strrev_cs_cs_test2()
        {
            ce103CsFunctions revrseee = new ce103CsFunctions();
            string originee = "Youare";
            string reveee = "erauoY";
            Assert.AreEqual(revrseee.ce103_strrev_cs_cs(originee), reveee);
        }

        [TestMethod]
        public void ce103_strrev_cs_cs_test3()
        {
            ce103CsFunctions revrseee = new ce103CsFunctions();
            string originee = "mother";
            string reveee = "rehtom";
            Assert.AreEqual(revrseee.ce103_strrev_cs_cs(originee), reveee);
        }

        [TestMethod]
        public void ce103_strrev_cs_vs_cscs_test1()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveee = new ce103fonksiyon();
            ce103CsFunctions reveee1 = new ce103CsFunctions();
            string originee = "Codeblocks";

            Assert.AreEqual(reveee.ce103_strrev_cs(originee), reveee1.ce103_strrev_cs_cs(originee));
        }

        [TestMethod]
        public void ce103_strrev_cs_vs_cscs_test2()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveee = new ce103fonksiyon();
            ce103CsFunctions reveee1 = new ce103CsFunctions();
            string originee = "Opera";

            Assert.AreEqual(reveee.ce103_strrev_cs(originee), reveee1.ce103_strrev_cs_cs(originee));
        }

        [TestMethod]
        public void ce103_strrev_cs_vs_cscs_test3()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveee = new ce103fonksiyon();
            ce103CsFunctions reveee1 = new ce103CsFunctions();
            string originee = "Edge";

            Assert.AreEqual(reveee.ce103_strrev_cs(originee), reveee1.ce103_strrev_cs_cs(originee));
        }

        [TestMethod]
        public void ce103_strlen_cs_test1()
        {
            ce103fonksiyon strleneee = new ce103fonksiyon();
            string streee = "Hospital";

            int result = strleneee.ce103_strlen_cs(streee);
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void ce103_strlen_cs_test2()
        {
            ce103fonksiyon strleneqq = new ce103fonksiyon();
            string streqq = "Repository";

            int result = strleneqq.ce103_strlen_cs(streqq);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void ce103_strlen_cs_test3()
        {
            ce103fonksiyon strleneqq = new ce103fonksiyon();
            string streqq = "Notepad";

            int resultqq = strleneqq.ce103_strlen_cs(streqq);
            Assert.AreEqual(resultqq, 7);
        }

        [TestMethod]
        public void ce103_strlen_cs_cs_test1()
        {
            ce103CsFunctions strleneqq = new ce103CsFunctions();
            string streqq = "Fire";

            int resultqq = strleneqq.ce103_strlen_cs_cs(streqq);
            Assert.AreEqual(resultqq, 4);
        }

        [TestMethod]
        public void ce103_strlen_cs_cs_test2()
        {
            ce103CsFunctions strleneqq = new ce103CsFunctions();
            string streqq = "Kyk";

            int resultqq = strleneqq.ce103_strlen_cs_cs(streqq);
            Assert.AreEqual(resultqq, 3);
        }

        [TestMethod]
        public void ce103_strlen_cs_cs_test3()
        {
            ce103CsFunctions strleneqq = new ce103CsFunctions();
            string streqq = "Facebook";

            int result = strleneqq.ce103_strlen_cs_cs(streqq);
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cscs_test1()
        {
            ce103CsFunctions cscsstrleneqq = new ce103CsFunctions();
            ce103fonksiyon csstrleneqq = new ce103fonksiyon();
            string streqq = "Phone";

            int cscsqq = cscsstrleneqq.ce103_strlen_cs_cs(streqq);
            int csqq = csstrleneqq.ce103_strlen_cs(streqq);

            Assert.AreEqual(csqq, cscsqq);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cscs_test2()
        {
            ce103CsFunctions cscsstrqq = new ce103CsFunctions();
            ce103fonksiyon csstrqq = new ce103fonksiyon();
            string streqq = "Empty";

            int cscsqq = cscsstrqq.ce103_strlen_cs_cs(streqq);
            int csqq = csstrqq.ce103_strlen_cs(streqq);

            Assert.AreEqual(csqq, cscsqq);
        }

        [TestMethod]
        public void ce103_strlen_cs_vs_cscs_test3()
        {
            ce103CsFunctions cscsstrqq = new ce103CsFunctions();
            ce103fonksiyon csstrqq = new ce103fonksiyon();
            string strqq = "Ubuntu";

            int cscsqq = cscsstrqq.ce103_strlen_cs_cs(strqq);
            int csqq = csstrqq.ce103_strlen_cs(strqq);

            Assert.AreEqual(csqq, cscsqq);
        }

        [TestMethod]
        public void ce103_strcat_cs_test1()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveqq = new ce103fonksiyon();
            string streqq = "Good";
            string streqq1 = "Morning";

            string resulteqq = "GoodMorning";

            Assert.AreEqual(reveqq.ce103_strcat_cs(streqq, streqq1), resulteqq);
        }

        [TestMethod]
        public void ce103_strcat_cs_test2()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveqq = new ce103fonksiyon();
            string streqq = "Istanbul";
            string streqq1 = "Bridge";

            string resultqq = "IstanbulBridge";

            Assert.AreEqual(reveqq.ce103_strcat_cs(streqq, streqq1), resultqq);
        }

        [TestMethod]
        public void ce103_strcat_cs_test3()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon reveqq = new ce103fonksiyon();
            string streqq = "Note";
            string streqq1 = "Pad";

            string resulteqq= "NotePad";

            Assert.AreEqual(reveqq.ce103_strcat_cs(streqq, streqq1), resulteqq);
        }

        [TestMethod]
        public void ce103_strcat_cs_cs_test1()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103CsFunctions revezz = new ce103CsFunctions();
            string strezz = "Hello";
            string strezz1 = "Friends";

            string resulte = "Hello Friends";

            Assert.AreEqual(revezz.ce103_strcat_cs_cs(strezz, strezz1), resulte);
        }

        [TestMethod]
        public void ce103_strcat_cs_cs_test2()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103CsFunctions revezz = new ce103CsFunctions();
            string strezz = "Hello";
            string strezz1 = "Celal";

            string resultezz = "HelloCelal";

            Assert.AreEqual(revezz.ce103_strcat_cs_cs(strezz, strezz1), resultezz);
        }

        [TestMethod]
        public void ce103_strcat_cs_cs_test3()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103CsFunctions revezz = new ce103CsFunctions();
            string strezz = "Good";
            string strezz1 = "Morning";

            string resultezz = "GoodMorning";

            Assert.AreEqual(revezz.ce103_strcat_cs_cs(strezz, strezz1), resultezz);
        }

        [TestMethod]
        public void ce103_strcat_cs_vs_cscs_test1()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon revezz = new ce103fonksiyon();
            ce103CsFunctions revezz1 = new ce103CsFunctions();
            string strezz = "Good";
            string strezz1 = "Mornings";

            Assert.AreEqual(revezz.ce103_strcat_cs(strezz, strezz1), revezz1.ce103_strcat_cs_cs(strezz, strezz1));
        }

        [TestMethod]
        public void ce103_strcat_cs_vs_cscs_test2()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon revezz = new ce103fonksiyon();
            ce103CsFunctions revezz1 = new ce103CsFunctions();
            string strezz = "Steam";
            string strezz1 = "Epic";

            Assert.AreEqual(revezz.ce103_strcat_cs(strezz, strezz1), revezz1.ce103_strcat_cs_cs(strezz, strezz1));
        }

        [TestMethod]
        public void ce103_strcat_cs_vs_cscs_test3()
        {
            // we're creating object of it otherwise we cannot use ce103functions class
            ce103fonksiyon revezz = new ce103fonksiyon();
            ce103CsFunctions revezz1 = new ce103CsFunctions();
            string strezz = "Kali";
            string strezz1 = "Linux";

            Assert.AreEqual(revezz.ce103_strcat_cs(strezz, strezz1), revezz1.ce103_strcat_cs_cs(strezz, strezz1));
        }

        [TestMethod]
        public void ce103_strcmp_cs_test1()
        {
            ce103fonksiyon strcmpezz = new ce103fonksiyon();
            const string strezz = "goodmornings";
            const string strezz1 = "goodmornings";
            Assert.AreEqual(strcmpezz.ce103_strcmp_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test2()
        {
            ce103fonksiyon strcmzz = new ce103fonksiyon();
            const string strezz = "good";
            const string strezz1 = "mornings";
            Assert.AreNotEqual(strcmzz.ce103_strcmp_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test3()
        {
            ce103fonksiyon strcmzz = new ce103fonksiyon();
            const string strezz = "Bad";
            const string strezz1 = "Bad";
            Assert.AreEqual(strcmzz.ce103_strcmp_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_cs_test1()
        {
            ce103CsFunctions strcmpezz = new ce103CsFunctions();
            const string strezz = "Facebook";
            const string strezz1 = "Facebook";
            Assert.AreEqual(strcmpezz.ce103_strcmp_cs_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_cs_test2()
        {
            ce103CsFunctions strcmzz = new ce103CsFunctions();
            const string strezz = "clever";
            const string strezz1 = "clever";
            Assert.AreEqual(strcmzz.ce103_strcmp_cs_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_cs_test3()
        {
            ce103CsFunctions strcmzz = new ce103CsFunctions();
            const string strezz = "Youtube";
            const string strezz1 = "Playstation";
            Assert.AreNotEqual(strcmzz.ce103_strcmp_cs_cs(strezz, strezz1), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cscs_test1()
        {
            ce103CsFunctions cscsstrcmzz = new ce103CsFunctions();
            ce103fonksiyon csstrcmzz = new ce103fonksiyon();
            const string strezz1 = "para";
            const string strezz2 = "para";
            Assert.AreEqual(cscsstrcmzz.ce103_strcmp_cs_cs(strezz1, strezz2), csstrcmzz.ce103_strcmp_cs(strezz1, strezz2));
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cscs_test2()
        {
            ce103CsFunctions cscsstrzz = new ce103CsFunctions();
            ce103fonksiyon csstrzz = new ce103fonksiyon();
            const string strezz = "diamond";
            const string strezz1 = "diamond";
            Assert.AreEqual(cscsstrzz.ce103_strcmp_cs_cs(strezz, strezz1), csstrzz.ce103_strcmp_cs(strezz, strezz1));
        }

        [TestMethod]
        public void ce103_strcmp_cs_vs_cscs_test3()
        {
            ce103CsFunctions cscsszz = new ce103CsFunctions();
            ce103fonksiyon csszz = new ce103fonksiyon();
            const string strezz = "Youare";
            const string strezz1 = "Youare";
            Assert.AreEqual(cscsszz.ce103_strcmp_cs_cs(strezz, strezz1), csszz.ce103_strcmp_cs(strezz, strezz1));
        }

        [TestMethod]
        public void ce103_strcpy_cs_test1()
        {
            ce103fonksiyon strcpzz = new ce103fonksiyon();
            string strezz = "cold";
            string strezz1 = "coke";
            string expectedStrezz = "coke";
            Assert.AreEqual(strcpzz.ce103_strcpy_cs(strezz, strezz1), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_test2()
        {
            ce103fonksiyon strcpyezz = new ce103fonksiyon();
            string strezz1 = "charge";
            string strezz2 = "Cable";
            string expectedStrezz = "Cable";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs(strezz1, strezz2), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_test3()
        {
            ce103fonksiyon strcpyezz = new ce103fonksiyon();
            string strezz1 = "Car";
            string strezz2 = "Bus";
            string expectedStrezz = "Bus";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs(strezz1, strezz2), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_cs_test1()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            string strezz1 = "Yellow";
            string strezz2 = "Lemon";
            string expectedStrezz = "Lemon";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_cs_test2()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            string strezz1 = "Test";
            string strezz2 = "Code";
            string expectedStrezz = "Code";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_cs_test3()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            string strezz1 = "Binary";
            string strezz2 = "Number";
            string expectedStrezz = "Number";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), expectedStrezz);
        }

        [TestMethod]
        public void ce103_strcpy_cs_vs_cscs_test1()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            ce103fonksiyon strcpyezz2 = new ce103fonksiyon();
            string strezz1 = "Good";
            string strezz2 = "Mornings";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), strcpyezz2.ce103_strcpy_cs(strezz1, strezz2));
        }

        [TestMethod]
        public void ce103_strcpy_cs_vs_cscs_test2()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            ce103fonksiyon strcpyezz2 = new ce103fonksiyon();
            string strezz1 = "Jack";
            string strezz2 = "Sparrow";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), strcpyezz2.ce103_strcpy_cs(strezz1, strezz2));
        }

        [TestMethod]
        public void ce103_strcpy_cs_vs_cscs_test3()
        {
            ce103CsFunctions strcpyezz = new ce103CsFunctions();
            ce103fonksiyon strcpyezz2 = new ce103fonksiyon();
            string strezz1 = "Celal";
            string strezz2 = "Enes";
            Assert.AreEqual(strcpyezz.ce103_strcpy_cs_cs(strezz1, strezz2), strcpyezz2.ce103_strcpy_cs(strezz1, strezz2));
        }

        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            ce103fonksiyon hex2binzz = new ce103fonksiyon();
            string hexstringzz = "1313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstringzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs(hexstringzz, hexstringzz.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            ce103fonksiyon hex2binzz = new ce103fonksiyon();
            string hexstringzz = "1111111111111111";
            byte[] expectedArrzz = { 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11 };
            byte[] hexArrzz = new byte[hexstringzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs(hexstringzz, hexstringzz.Length, hexArrzz);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArrzz, hexArrzz);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            ce103fonksiyon hex2binzz = new ce103fonksiyon();
            string hexstringzz = "FAFAFAFAFAFAFAFA";
            byte[] expectedArrzz = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] hexArrzz = new byte[hexstringzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs(hexstringzz, hexstringzz.Length, hexArrzz);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArrzz, hexArrzz);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_cs_test1()
        {
            ce103CsFunctions hex2binzz = new ce103CsFunctions();
            string lenzz = "AAFBCD234324";
            byte[] resultzz = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            byte[] hexzz = new byte[lenzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs_cs(lenzz, lenzz.Length, hexzz);

            // assert by sequence
            CollectionAssert.AreEqual(resultzz, hexzz);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_cs_test2()
        {
            ce103CsFunctions hex2binzz = new ce103CsFunctions();
            string lenzz = "2348975982379872239487";
            byte[] resultzz = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexzz = new byte[lenzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs_cs(lenzz, lenzz.Length, hexzz);

            // assert by sequence
            CollectionAssert.AreEqual(resultzz, hexzz);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_cs_test3()
        {
            ce103CsFunctions hex2binzz = new ce103CsFunctions();
            string lenzz = "1313131313131313131313";
            byte[] resultzz = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexzz = new byte[lenzz.Length / 2];
            hex2binzz.ce103_hex2bin_cs_cs(lenzz, lenzz.Length, hexzz);

            // assert by sequence
            CollectionAssert.AreEqual(resultzz, hexzz);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cscs_test1()
        {
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            ce103fonksiyon csezz = new ce103fonksiyon();
            string lenezz = "FFFFFFFFFF";

            byte[] hex = new byte[lenezz.Length / 2];
            cscsezz.ce103_hex2bin_cs_cs(lenezz, lenezz.Length, hex);

            byte[] hex2 = new byte[lenezz.Length / 2];
            csezz.ce103_hex2bin_cs(lenezz, lenezz.Length, hex2);
            
            // assert by sequence
            CollectionAssert.AreEqual(hex2, hex);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cscs_test2()
        {
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            ce103fonksiyon csezz = new ce103fonksiyon();
            string lenezz = "ABCDEAEC";
            byte[] resultzz = { 0xAB, 0xCD, 0xEA, 0xEC };

            byte[] hexzz = new byte[lenezz.Length / 2];
            cscsezz.ce103_hex2bin_cs_cs(lenezz, lenezz.Length, hexzz);

            byte[] hexzz2 = new byte[lenezz.Length / 2];
            csezz.ce103_hex2bin_cs(lenezz, lenezz.Length, hexzz2);

            // assert by sequence
            CollectionAssert.AreEqual(hexzz, hexzz2);
        }

        [TestMethod]
        public void ce103_hex2bin_cs_vs_cscs_test3()
        {
            ce103CsFunctions cscseezz = new ce103CsFunctions();
            ce103fonksiyon cseezz = new ce103fonksiyon();
            string leneezz = "91423FC23A234832FA";
            byte[] expectedArr = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexzz = new byte[leneezz.Length / 2];
            cscseezz.ce103_hex2bin_cs_cs(leneezz, leneezz.Length, hexzz);

            byte[] hex2 = new byte[leneezz.Length / 2];
            cseezz.ce103_hex2bin_cs(leneezz, leneezz.Length, hex2);

            // assert by sequence
            CollectionAssert.AreEqual(hex2, hexzz);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            ce103fonksiyon writtenezz = new ce103fonksiyon();
            byte[] binezz = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] lenezz2 = new char[binezz.Length * 2];
            char[] lenezz = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            writtenezz.ce103_bin2hex_cs(binezz, binezz.Length, lenezz2);

            CollectionAssert.AreEqual(lenezz2, lenezz);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            ce103fonksiyon csezz = new ce103fonksiyon();
            byte[] binezz = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] lenezz2 = new char[binezz.Length * 2];
            char[] lenezz = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            csezz.ce103_bin2hex_cs(binezz, binezz.Length, lenezz2);

            CollectionAssert.AreEqual(lenezz2, lenezz);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            ce103fonksiyon csezz = new ce103fonksiyon();
            byte[] binezz = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] lenezz2 = new char[binezz.Length * 2];
            char[] lenezz = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            csezz.ce103_bin2hex_cs(binezz, binezz.Length, lenezz2);

            CollectionAssert.AreEqual(lenezz2, lenezz);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_cs_test1()
        {
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            byte[] binezz = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            //char[] lene2 = new char[bin.Length * 2];
            //char[] lene = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A'};
            //string lene = "FAFAFAFAFAFAFAFA";
            StringBuilder lenezz2 = new StringBuilder(16);
            cscsezz.ce103_bin2hex_cs_cs(binezz, binezz.Length, lenezz2);
            StringBuilder lene = new StringBuilder("FAFAFAFAFAFAFAFA");
            StringAssert.Equals(lene, lenezz2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_cs_test2()
        {
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            byte[] binezz = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            StringBuilder lenezz2 = new StringBuilder(16);
            StringBuilder lenezz = new StringBuilder("1111111111111111");

            cscsezz.ce103_bin2hex_cs_cs(binezz, binezz.Length, lenezz2);

            StringAssert.Equals(lenezz, lenezz2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_cs_test3()
        {
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            byte[] binezz = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };

            char[] hexstringzz = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };
            StringBuilder lenezz2 = new StringBuilder(16);
            StringBuilder lenezz = new StringBuilder("AAFBCD234324");
            cscsezz.ce103_bin2hex_cs_cs(binezz, binezz.Length, lenezz2);

            StringAssert.Equals(lenezz2, lenezz);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cscs_test1()
        {
            ce103fonksiyon csezz = new ce103fonksiyon();
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            byte[] binezz = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            StringBuilder lene2 = new StringBuilder(16);
            char[] lenezz = new char[binezz.Length * 2];
            csezz.ce103_bin2hex_cs(binezz, binezz.Length, lenezz);
            cscsezz.ce103_bin2hex_cs_cs(binezz, binezz.Length, lene2);

            StringBuilder.Equals(lenezz, lene2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cscs_test2()
        {
            ce103fonksiyon csezz = new ce103fonksiyon();
            ce103CsFunctions cscsezz = new ce103CsFunctions();
            byte[] binezz = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            StringBuilder lenezz2 = new StringBuilder(16);
            char[] lenezz = new char[binezz.Length * 2];
            csezz.ce103_bin2hex_cs(binezz, binezz.Length, lenezz);
            cscsezz.ce103_bin2hex_cs_cs(binezz, binezz.Length, lenezz2);

            StringAssert.Equals(lenezz, lenezz2);
        }

        [TestMethod]
        public void ce103_bin2hex_cs_vs_cscs_test3()
        {
            ce103fonksiyon cse = new ce103fonksiyon();
            ce103CsFunctions cscse = new ce103CsFunctions();
            byte[] bine = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            StringBuilder lene2 = new StringBuilder(16);
            char[] lene = new char[bine.Length * 2];
            cse.ce103_bin2hex_cs(bine, bine.Length, lene);
            cscse.ce103_bin2hex_cs_cs(bine, bine.Length, lene2);


            StringAssert.Equals(lene, lene2);
        }
    }
}