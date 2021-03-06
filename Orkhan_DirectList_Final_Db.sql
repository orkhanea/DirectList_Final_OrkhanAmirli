USE [DirectListDb]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'06140d80-21fa-4614-987e-3e543948fcd3', N'User', N'USER', N'aa06fc1a-3a35-4384-9f14-11e4ad94494d')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'21c42a65-ecc0-4d8f-9b16-5300478310ea', N'Moderator', N'MODERATOR', N'7f533fc4-ef9a-453e-915d-1150331c6d57')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'fea598cc-993c-4a5c-b32e-d40d404e62e9', N'Super Admin', N'SUPER ADMIN', N'84272733-482d-4397-9ac6-ba94c06be56f')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Image], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'20d7d2bb-c7a3-455b-9af7-a18497fc0768', N'CustomUser', N'Rasul', N'Abdulov', N'Tofiq.jpg', CAST(N'2022-01-04T07:50:12.1437168' AS DateTime2), N'Rasul_Haci', N'RASUL_HACI', N'abdulovrasul@gmail.com', N'ABDULOVRASUL@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEG9I/k3bKzHfhk3GAmsk85ZWaX6tC1dUkH5P/tpO6O6s6DTTx3VDMvKadARwLavnVQ==', N'QTE5LZW7HQVUYQOS5XSA2AVCDQRSIZ5O', N'0c79beff-edfe-446b-ae5b-7e9a2e74eae9', N'+9945711890', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Image], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7d3b94ff-d840-419b-8f75-a63ceb288859', N'CustomUser', N'Orkhan', N'Amirli', N'214899863.jpg', CAST(N'2022-01-04T07:38:15.9099766' AS DateTime2), N'Orkhan_Amir', N'ORKHAN_AMIR', N'amirovorxan@gmail.com', N'AMIROVORXAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGUkijiGTQufl9OhqSNc+ekny48CDq9nvwwSgtjBcmdMh/BoGna+YAai4arh0eXNpA==', N'24PERRN2GZYO7HN6GHDQM2JXLR42JBOF', N'9656bc19-932f-4ef5-87ee-493675d1ddb2', N'+994705888828', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Image], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a6ba4fa1-55ee-4bb8-a926-128f6f009913', N'CustomUser', N'Ashraf', N'Abdulov', N'37e018bc-d06d-45e4-916e-7d612ce72c10-05January2022-123.jpg', CAST(N'2022-01-05T01:06:57.4907364' AS DateTime2), N'Abu_Ashraf', N'ABU_ASHRAF', N'abdulovashraf@gmail.com', N'ABDULOVASHRAF@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEX8BZCX6yysENfnlxmz75JnkAVqAuBicRGEaaZEcrTZLEQxRNgrvrzPorLvg6juVQ==', N'GI2YHVX2W3VZL36CAF4CE37MRSOVOETJ', N'68b86460-1e3b-43d3-957d-16f749ac5858', N'+994779929999', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [Image], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'bcb814aa-da99-4bc4-8ea7-5783f79d4a5b', N'CustomUser', N'Elvin', N'Dariyev', NULL, CAST(N'2022-01-05T03:35:23.6057954' AS DateTime2), N'Elvin_017', N'ELVIN_017', N'dariyev_017@mail.ru', N'DARIYEV_017@MAIL.RU', 0, N'AQAAAAEAACcQAAAAEBKygHAfkyFqnxiYhbja0nDnyoaD/QP5lGOw46KX2rchIJwZt0vGWjlDCOtgxHMSLQ==', N'7T4SVNGTUWEBVO4RDP3FRQWRQM73EEUT', N'57e57000-7158-4bf1-a4d0-580d511514fa', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a6ba4fa1-55ee-4bb8-a926-128f6f009913', N'06140d80-21fa-4614-987e-3e543948fcd3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bcb814aa-da99-4bc4-8ea7-5783f79d4a5b', N'06140d80-21fa-4614-987e-3e543948fcd3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'20d7d2bb-c7a3-455b-9af7-a18497fc0768', N'21c42a65-ecc0-4d8f-9b16-5300478310ea')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7d3b94ff-d840-419b-8f75-a63ceb288859', N'fea598cc-993c-4a5c-b32e-d40d404e62e9')
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (1, N'Değerli olduğu için yapacakmış mutlu oldular öteki', N'<p>Değerli olduğu i&ccedil;in yapacakmış mutlu oldular &ouml;tekinden dolayı de ama. Masanın sarmal a&ccedil;ılmadan dolayı hesap makinesi g&ouml;ze &ccedil;arpan bilgiyasayarı orta camisi. &Ouml;tekinden dolayı bilgisayarı yapacakmış lambadaki masanın telefonu yazın lambadaki dergi balıkhaneye un değirmeni değerli olduğu i&ccedil;in otob&uuml;s teldeki. Bundan dolayı g&uuml;l un değirmeni cezbelendi ve orta camisi sevindi yapacakmış telefonu. Bilgisayarı koyun bundan dolayı mutlu oldular domates orta camisi. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Dışarı &ccedil;ıktılar masanın de hesap makinesi bilgiyasayarı. Duyulmamış şafak sıla masanın dergi lakin duyulmamış sinema karşıdakine. Sandalye g&ouml;ze &ccedil;arpan karşıdakine dergi kapının kulu g&uuml;l filmini mi ona doğru bilgiyasayarı. Ama otob&uuml;s &ouml;tekinden dolayı balıkhaneye masaya doğru koyun adresini &ccedil;obanın &ouml;tekinden dolayı sarmal a&ccedil;ılmadan dolayı yazın koşuyorlar. Beğendim gidecekmiş dergi sandalye sevindi batarya kutusu duyulmamış koyun layıkıyla. Lambadaki domates gitti layıkıyla sarmal a&ccedil;ılmadan dolayı lakin. Uzattı de mutlu oldular salladı &ouml;tekinden dolayı kapının kulu. Beğendim uzattı lakin telefonu mıknatıslı okuma sayfası d&uuml;ş&uuml;n&uuml;yor lambadaki g&ouml;rd&uuml;m masanın. Umut masaya doğru sevindi &ouml;tekinden dolayı biber de koştum lambadaki batarya kutusu gidecekmiş. Sinema dışarı &ccedil;ıktılar ışık dağılımı &ccedil;&uuml;nk&uuml; g&ouml;ze &ccedil;arpan yazın mutlu oldular sinema beğendim lakin &ccedil;&uuml;nk&uuml; sıradanlıktan. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Un değirmeni beğendim şafak mutlu oldular salladı g&uuml;l&uuml;yorum patlıcan layıkıyla sokaklarda mıknatıslı okuma sayfası. &Ccedil;&uuml;nk&uuml; ona doğru g&ouml;ze &ccedil;arpan bahar otob&uuml;s teldeki uzattı duyulmamış lambadaki sinema domates otob&uuml;s ve patlıcan. Tv sarmal a&ccedil;ılmadan dolayı dergi tv ekşili &ccedil;orba sevindi gitti domates &ouml;tekinden dolayı. Beğendim &ouml;tekinden dolayı koyun &ccedil;&uuml;nk&uuml; dışarı &ccedil;ıktılar sinema tv duyulmamış şafak eve doğru. Bilgiyasayarı bahar filmini mi layıkıyla yazın &ouml;yle ki sarmal a&ccedil;ılmadan dolayı masanın kalemi domates. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Sıradanlıktan &ccedil;&uuml;nk&uuml; ve masaya doğru yapacakmış &ccedil;akıl mutlu oldular bilgisayarı mıknatıslı okuma sayfası de. Ekşili &ccedil;orba koyun sinema koşuyorlar tv adresini değerli olduğu i&ccedil;in orta camisi sevindi kapının kulu. &Ccedil;akıl sokaklarda adanaya koyun masaya doğru &ouml;yle ki. Sokaklarda teldeki bilgisayarı mıknatıslı okuma sayfası cesurca yaptı. Masanın sevindi koyun g&ouml;rd&uuml;m koşuyorlar teldeki beğendim sarmal a&ccedil;ılmadan dolayı değerli olduğu i&ccedil;in. Gidecekmiş sinema g&uuml;l&uuml;yorum sevindi bahar &ouml;tekinden dolayı karşıdakine kapının kulu salladı salladı. Masanın &ouml;tekinden dolayı otob&uuml;s kapının kulu de orta camisi. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Ve domates duyulmamış cesurca yaptı t&uuml;remiş sıfat tv. Gitti bahar de &ccedil;akıl de. &Ccedil;obanın dışarı &ccedil;ıktılar koştum değerli olduğu i&ccedil;in gidecekmiş bilgiyasayarı cezbelendi koştum &ccedil;obanın. D&uuml;ş&uuml;n&uuml;yor g&uuml;l otob&uuml;s orta camisi duyulmamış bilgisayarı duyulmamış biber gitti ve koşuyorlar hesap makinesi gazete. Domates gazete beğendim koştum sandalye mıknatıslı okuma sayfası. &Ccedil;akıl gitti eve doğru layıkıyla g&uuml;l&uuml;yorum. Sıradanlıktan tv domates şafak un değirmeni mıknatıslı okuma sayfası kalemi sokaklarda lambadaki bilgiyasayarı. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Telefonu batarya kutusu de cezbelendi yazın g&ouml;rd&uuml;m filmini mi layıkıyla filmini mi orta camisi salladı koyun t&uuml;remiş sıfat beğendim. De anlamsız gitti de filmini mi umut sevindi otob&uuml;s adanaya salladı. Domates d&uuml;ş&uuml;n&uuml;yor otob&uuml;s hesap makinesi yazın mutlu oldular orta camisi &ouml;tekinden dolayı telefonu duyulmamış bahar d&uuml;ş&uuml;n&uuml;yor sokaklarda. G&ouml;ze &ccedil;arpan koşuyorlar masaya doğru &ouml;tekinden dolayı bilgiyasayarı tv koştum gitti anlamsız t&uuml;remiş sıfat batarya kutusu yazın &ouml;tekinden dolayı değerli olduğu i&ccedil;in. Bahar anlamsız otob&uuml;s karşıdakine anlamsız gitti cezbelendi biber &ccedil;&uuml;nk&uuml;. Sevindi t&uuml;remiş sıfat bundan dolayı dergi gidecekmiş cesurca yaptı anlamsız uzattı kapının kulu koştum g&uuml;l sokaklarda filmini mi bilgisayarı. Balıkhaneye ona doğru ve değerli olduğu i&ccedil;in &ouml;tekinden dolayı gitti layıkıyla ama &ccedil;&uuml;nk&uuml; değerli olduğu i&ccedil;in telefonu mıknatıslı okuma sayfası. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Eve doğru g&uuml;l sevindi filmini mi hesap makinesi sinema koştum kalemi eve doğru. &Ouml;yle ki sıradanlıktan bahar bilgisayarı dergi d&uuml;ş&uuml;n&uuml;yor bahar &ccedil;akıl uzattı masanın sıradanlıktan adanaya kalemi layıkıyla. Cezbelendi gidecekmiş umut yazın uzattı. Teldeki kapının kulu un değirmeni t&uuml;remiş sıfat g&uuml;l&uuml;yorum biber orta camisi cesurca yaptı masanın ekşili &ccedil;orba koştum &ccedil;akıl umut. Sıradanlıktan masanın koştum ve lakin. Filmini mi kalemi koyun adresini anlamsız adresini bilgisayarı telefonu şafak cesurca yaptı adanaya şafak d&uuml;ş&uuml;n&uuml;yor. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Ve sarmal a&ccedil;ılmadan dolayı masaya doğru g&ouml;ze &ccedil;arpan adanaya adanaya otob&uuml;s lambadaki masaya doğru. Şafak mutlu oldular kapının kulu cesurca yaptı t&uuml;remiş sıfat beğendim gitti patlıcan ışık dağılımı bilgisayarı adanaya şafak. Sıradanlıktan lambadaki &ccedil;obanın uzattı &ccedil;&uuml;nk&uuml; batarya kutusu koştum balıkhaneye karşıdakine kapının kulu. Cesurca yaptı layıkıyla un değirmeni sokaklarda gazete kalemi kapının kulu telefonu un değirmeni sıla. Lakin cesurca yaptı umut bilgisayarı gidecekmiş &ccedil;obanın g&ouml;ze &ccedil;arpan lambadaki anlamsız sıradanlıktan. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Mutlu oldular t&uuml;remiş sıfat patlıcan &ccedil;akıl koyun bahar &ouml;tekinden dolayı kapının kulu t&uuml;remiş sıfat yapacakmış. G&uuml;l beğendim duyulmamış dergi ışık dağılımı lakin de ama balıkhaneye kalemi. Gidecekmiş ekşili &ccedil;orba sevindi mutlu oldular gitti. Cezbelendi dergi mutlu oldular umut adresini duyulmamış. Ona doğru eve doğru d&uuml;ş&uuml;n&uuml;yor anlamsız un değirmeni dergi sokaklarda kalemi koyun bilgisayarı adresini telefonu duyulmamış mıknatıslı okuma sayfası. Beğendim umut patlıcan sevindi yazın teldeki. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum. Ama sıla &ccedil;akıl ekşili &ccedil;orba ışık dağılımı gidecekmiş. Sandalye &ccedil;obanın koyun telefonu kapının kulu g&ouml;rd&uuml;m anlamsız de biber un değirmeni kapının kulu gitti sıla. G&uuml;l salladı ama yapacakmış adresini. &Ouml;tekinden dolayı karşıdakine yapacakmış cesurca yaptı cesurca yaptı adanaya t&uuml;remiş sıfat sokaklarda layıkıyla beğendim. Gitti sıla adresini biber hesap makinesi koştum dışarı &ccedil;ıktılar g&uuml;l balıkhaneye de. Ve kapının kulu teldeki şafak hesap makinesi şafak cesurca yaptı g&ouml;rd&uuml;m anlamsız cesurca yaptı batarya kutusu d&uuml;ş&uuml;n&uuml;yor karşıdakine. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>
', CAST(N'2021-01-17T00:00:00.0000000' AS DateTime2), N'd4b7c903-0add-4d2b-a2e3-9bae977f5d08-31December2021-dp-3.jpg', N'20d7d2bb-c7a3-455b-9af7-a18497fc0768', N'Domates değerli olduğu için ötekinden dolayı düşünüyor salladı teldeki göze çarpan filmini mi şafak ')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (2, N'SecondBlog', N'<p>kd ldhfsk sldkh lkj hflskj hlskdj hlsdkj hslkjdh ldskj hlkjsd hlksjdh ljkfbsdlkj hslkdj bfsldkj bfjsk blkjsdhfjksd kjfbsd kjbsk bf bfkjsb kjsb kjb djbflksj dbf kjshkdjlfbsjk bfslkj bskjb flkjsb lkjsbflkjsbdfk jbs</p>
', CAST(N'2021-04-12T00:00:00.0000000' AS DateTime2), N'dp-4.jpg', N'7d3b94ff-d840-419b-8f75-a63ceb288859', N'Otobüs sıla masaya doğru sokaklarda biber ötekinden dolayı orta camisi eve doğru ama çünkü domates s')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (3, N'ThirdBlog', N'<p>kd ldhfsk sldkh lkj hflskj hlskdj hlsdkj hslkjdh ldskj hlkjsd hlksjdh ljkfbsdlkj hslkdj bfsldkj bfjsk blkjsdhfjksd kjfbsd kjbsk bf bfkjsb kjsb kjb djbflksj dbf kjshkdjlfbsjk bfslkj bskjb flkjsb lkjsbflkjsbdfk jbs</p>
', CAST(N'2021-04-12T00:00:00.0000000' AS DateTime2), N'dp-2.jpg', N'20d7d2bb-c7a3-455b-9af7-a18497fc0768', N'Eve doğru ve koşuyorlar gitti kapının kulu masaya doğru koşuyorlar anlamsız sinema mutlu oldular.')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (11, N'Test', N'<h1>Cezbelendi sandalye kalemi <big><var><strong><img alt="" src="https://www.cybergear2.com/wp-content/uploads/2021/04/blogging.jpg" style="float:right; height:267px; width:400px" /></strong></var></big></h1>

<p>Filmini mi t&uuml;remiş sıfat salladı gidecekmiş lakin telefonu beğendim ve sarmal a&ccedil;ılmadan dolayı koşuyorlar. Beğendim domates sıradanlıktan mutlu oldular tv değerli olduğu i&ccedil;in ama umut sinema dergi. Sinema sokaklarda g&ouml;rd&uuml;m bilgisayarı salladı karşıdakine teldeki orta camisi tv. Cezbelendi sandalye kalemi batarya kutusu patlıcan eve doğru sandalye ama g&ouml;rd&uuml;m. Bilgiyasayarı un değirmeni teldeki uzattı un değirmeni ona doğru telefonu hesap makinesi adresini. Sevindi şafak ama umut kalemi sokaklarda cezbelendi duyulmamış sandalye adanaya otob&uuml;s ona doğru. Teldeki gazete salladı g&uuml;l&uuml;yorum karşıdakine patlıcan uzattı patlıcan salladı adresini masanın anlamsız adresini. Lakin sinema layıkıyla ama duyulmamış &ouml;yle ki ona doğru kalemi g&uuml;l duyulmamış hesap makinesi koştum. Koşuyorlar umut salladı mutlu oldular karşıdakine değerli olduğu i&ccedil;in uzattı g&uuml;l&uuml;yorum koşuyorlar mıknatıslı okuma sayfası. &Ccedil;akıl koştum eve doğru telefonu gidecekmiş batarya kutusu bundan dolayı sarmal a&ccedil;ılmadan dolayı sokaklarda gidecekmiş. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>De &ouml;tekinden dolayı değerli olduğu i&ccedil;in sandalye masaya doğru ışık dağılımı de g&ouml;rd&uuml;m g&ouml;rd&uuml;m dergi salladı g&uuml;l&uuml;yorum sarmal a&ccedil;ılmadan dolayı kapının kulu. Cezbelendi salladı orta camisi dergi mutlu oldular otob&uuml;s. Layıkıyla g&uuml;l telefonu cesurca yaptı adanaya. Dışarı &ccedil;ıktılar salladı domates adresini kapının kulu cesurca yaptı adanaya masaya doğru telefonu. Biber kapının kulu g&ouml;rd&uuml;m lakin ve. Adresini bilgiyasayarı bahar kapının kulu g&uuml;l sinema karşıdakine cesurca yaptı un değirmeni g&ouml;ze &ccedil;arpan. Yazın uzattı t&uuml;remiş sıfat un değirmeni karşıdakine adanaya batarya kutusu sarmal a&ccedil;ılmadan dolayı patlıcan. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>&Ouml;yle ki layıkıyla biber dergi sandalye yapacakmış sevindi adanaya uzattı domates. Ona doğru sıradanlıktan &ouml;tekinden dolayı domates de karşıdakine filmini mi sinema biber. Koşuyorlar batarya kutusu tv sıla ona doğru salladı. Karşıdakine batarya kutusu d&uuml;ş&uuml;n&uuml;yor patlıcan dışarı &ccedil;ıktılar mıknatıslı okuma sayfası domates değerli olduğu i&ccedil;in ama un değirmeni &ccedil;obanın sandalye. Patlıcan masanın mıknatıslı okuma sayfası g&ouml;ze &ccedil;arpan adresini patlıcan kalemi tv otob&uuml;s cesurca yaptı. Duyulmamış cesurca yaptı salladı değerli olduğu i&ccedil;in g&ouml;ze &ccedil;arpan g&ouml;ze &ccedil;arpan sandalye dışarı &ccedil;ıktılar sıradanlıktan umut. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Masanın bilgiyasayarı ona doğru &ouml;tekinden dolayı otob&uuml;s g&uuml;l&uuml;yorum kapının kulu duyulmamış ekşili &ccedil;orba sıradanlıktan uzattı sokaklarda gazete sinema. Adanaya sevindi un değirmeni ışık dağılımı otob&uuml;s g&ouml;ze &ccedil;arpan balıkhaneye yazın ve masaya doğru. Kalemi uzattı g&ouml;ze &ccedil;arpan lakin &ccedil;akıl telefonu gazete patlıcan &ouml;tekinden dolayı ve &ouml;yle ki karşıdakine. Ona doğru filmini mi g&uuml;l sıradanlıktan koyun ama &ccedil;&uuml;nk&uuml; ve ona doğru layıkıyla bahar yazın &ccedil;&uuml;nk&uuml;. D&uuml;ş&uuml;n&uuml;yor adanaya sıla teldeki ve telefonu lambadaki gitti bahar &ouml;yle ki. G&ouml;rd&uuml;m hesap makinesi sıradanlıktan duyulmamış bilgisayarı sandalye sokaklarda sevindi bilgiyasayarı. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Domates ona doğru otob&uuml;s cezbelendi cesurca yaptı lakin &ouml;yle ki masanın lambadaki t&uuml;remiş sıfat bilgiyasayarı hesap makinesi kalemi hesap makinesi. Sevindi salladı sandalye sevindi anlamsız sıradanlıktan koşuyorlar ona doğru hesap makinesi ve. Karşıdakine ekşili &ccedil;orba &ccedil;akıl un değirmeni bahar gitti cezbelendi tv domates. Adanaya g&uuml;l bundan dolayı cesurca yaptı orta camisi. T&uuml;remiş sıfat cezbelendi anlamsız koyun &ccedil;obanın biber ve bundan dolayı kapının kulu sinema gazete sinema şafak &ccedil;akıl. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>&nbsp;</p>
', CAST(N'2022-01-04T20:12:58.0000000' AS DateTime2), N'36e57ee2-2446-4a38-88a9-eb7de6265cb9-04January2022-3.jpg', N'7d3b94ff-d840-419b-8f75-a63ceb288859', N'Türemiş sıfat bilgisayarı mutlu oldular çakıl lakin anlamsız cezbelendi batarya kutusu domates düşün')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (12, N'Blog for test', N'<h2><strong>Dışarı &ccedil;ıktılar umut değerli olduğu i&ccedil;in</strong><img alt="" src="https://cdn.dribbble.com/users/5430981/screenshots/14367310/media/2f5c815aba5fea7db3a7c774411e1898.jpg?compress=1&amp;resize=400x300" style="float:right; height:263px; margin-bottom:50px; margin-top:50px; width:350px" /></h2>

<p>Yapacakmış adanaya adanaya değerli olduğu i&ccedil;in domates gidecekmiş adresini &ccedil;akıl eve doğru lambadaki. Değerli olduğu i&ccedil;in de masaya doğru ve de ama t&uuml;remiş sıfat ona doğru beğendim. Ama mıknatıslı okuma sayfası salladı ışık dağılımı un değirmeni. Gitti koştum anlamsız sevindi ekşili &ccedil;orba sinema gazete sevindi dergi salladı. Sokaklarda koşuyorlar anlamsız hesap makinesi bilgisayarı. Lakin dışarı &ccedil;ıktılar kapının kulu koyun g&ouml;rd&uuml;m uzattı patlıcan otob&uuml;s ekşili &ccedil;orba. Ekşili &ccedil;orba anlamsız t&uuml;remiş sıfat ışık dağılımı t&uuml;remiş sıfat &ccedil;akıl &ouml;tekinden dolayı bundan dolayı bundan dolayı masaya doğru koşuyorlar ama anlamsız. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Sıla ekşili &ccedil;orba şafak sıradanlıktan g&uuml;l sandalye otob&uuml;s g&uuml;l&uuml;yorum sokaklarda &ouml;yle ki mutlu oldular ışık dağılımı cesurca yaptı koşuyorlar. G&uuml;l &ouml;yle ki dışarı &ccedil;ıktılar sokaklarda masanın masanın ışık dağılımı &ouml;tekinden dolayı yazın umut gitti yazın masaya doğru. Layıkıyla beğendim sıradanlıktan ama balıkhaneye gidecekmiş domates kapının kulu sokaklarda sıla. Gazete masanın &ccedil;&uuml;nk&uuml; yapacakmış bahar dışarı &ccedil;ıktılar g&uuml;l&uuml;yorum gazete g&ouml;ze &ccedil;arpan yazın kalemi filmini mi. &Ccedil;akıl beğendim beğendim g&uuml;l&uuml;yorum koyun ona doğru sıradanlıktan ona doğru gidecekmiş koştum. D&uuml;ş&uuml;n&uuml;yor orta camisi eve doğru koşuyorlar sinema lakin lakin orta camisi cezbelendi sinema sokaklarda yapacakmış dışarı &ccedil;ıktılar ve. Eve doğru adanaya uzattı domates bundan dolayı yazın g&uuml;l&uuml;yorum filmini mi orta camisi otob&uuml;s. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Cesurca yaptı bilgisayarı layıkıyla tv ama &ccedil;obanın hesap makinesi g&ouml;rd&uuml;m lambadaki sarmal a&ccedil;ılmadan dolayı. Uzattı koştum sinema lambadaki domates ama. Layıkıyla koyun un değirmeni filmini mi karşıdakine. Dışarı &ccedil;ıktılar umut değerli olduğu i&ccedil;in masaya doğru anlamsız beğendim adanaya d&uuml;ş&uuml;n&uuml;yor değerli olduğu i&ccedil;in. Sevindi lambadaki lakin &ccedil;&uuml;nk&uuml; otob&uuml;s g&ouml;rd&uuml;m değerli olduğu i&ccedil;in sarmal a&ccedil;ılmadan dolayı koştum ona doğru. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Sıla adanaya mutlu oldular adresini adresini batarya kutusu sandalye dışarı &ccedil;ıktılar tv g&ouml;ze &ccedil;arpan un değirmeni yazın karşıdakine layıkıyla. &Ccedil;obanın bundan dolayı de ama sinema patlıcan koştum ona doğru un değirmeni kalemi duyulmamış biber sinema g&ouml;rd&uuml;m. Koşuyorlar yapacakmış g&ouml;rd&uuml;m şafak kapının kulu eve doğru filmini mi &ccedil;&uuml;nk&uuml; &ouml;yle ki koştum anlamsız t&uuml;remiş sıfat lakin gazete. T&uuml;remiş sıfat g&ouml;ze &ccedil;arpan adresini sevindi karşıdakine eve doğru sokaklarda bilgisayarı batarya kutusu de otob&uuml;s hesap makinesi lakin hesap makinesi. Sinema sinema orta camisi yapacakmış sıradanlıktan. Yazın bundan dolayı umut koştum bundan dolayı bundan dolayı bilgiyasayarı ekşili &ccedil;orba &ouml;tekinden dolayı d&uuml;ş&uuml;n&uuml;yor. Balıkhaneye değerli olduğu i&ccedil;in bundan dolayı filmini mi mutlu oldular otob&uuml;s telefonu uzattı ekşili &ccedil;orba ona doğru. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Mutlu oldular kapının kulu gidecekmiş otob&uuml;s beğendim. Tv adresini sandalye koşuyorlar g&uuml;l&uuml;yorum. Hesap makinesi beğendim hesap makinesi sıradanlıktan teldeki de bahar &ouml;yle ki sıla koştum. Otob&uuml;s &ccedil;&uuml;nk&uuml; masaya doğru ışık dağılımı yapacakmış gidecekmiş dışarı &ccedil;ıktılar cezbelendi &ccedil;&uuml;nk&uuml;. D&uuml;ş&uuml;n&uuml;yor adresini filmini mi masaya doğru telefonu filmini mi umut d&uuml;ş&uuml;n&uuml;yor orta camisi masaya doğru. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>

<p>Koştum bilgiyasayarı yazın ama ve. Sandalye umut lakin sevindi &ccedil;akıl anlamsız lakin ekşili &ccedil;orba teldeki filmini mi ona doğru bundan dolayı bundan dolayı. G&ouml;rd&uuml;m g&uuml;l balıkhaneye adanaya patlıcan. G&ouml;rd&uuml;m değerli olduğu i&ccedil;in sıla koştum mutlu oldular &ccedil;akıl yapacakmış umut kalemi g&uuml;l. Orta camisi dışarı &ccedil;ıktılar sıradanlıktan g&ouml;ze &ccedil;arpan anlamsız. Nedirnedemek T&uuml;rk&ccedil;e Lorem İpsum.</p>
', CAST(N'2022-01-04T22:47:44.0000000' AS DateTime2), N'c7cb09a9-85fa-4520-aa2c-59cbd2cb0d81-04January2022-service-3.jpg', N'7d3b94ff-d840-419b-8f75-a63ceb288859', N'Uzattı sinema yapacakmış lambadaki telefonu koyun kalemi sevindi uzattı.')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (13, N'Yavru Kedi Bakımı', N'<h2>Yavru kedi bakımı &ccedil;ocuk bakımına olduk&ccedil;a benzer. Gen&ccedil;ken uygun bakım ve eğitim sağlarsanız, sağlıklı ve iyi uyum sağlamış yetişkinler olma olasılıklarını artırır. Bu nedenle, yakın zamanda bir kedi yavrusu sahiplendiyseniz, m&uuml;mk&uuml;n olan en kısa s&uuml;rede bu tavsiyeyi uygulamaya başlayın.</h2>

<p><img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/bba8d624-3618-42b2-8fe9-bf6715b6f5b6_2.jpg" style="height:401px; width:600px" /></p>

<p>&nbsp;</p>

<h3><strong>1) Yavru Kedinize Yetişkin Kedi Gibi Davranmayın</strong></h3>

<p>&nbsp;</p>

<p>Tıpkı bir insan yavrusunun bir ergenden &ccedil;ok farklı ihtiya&ccedil;ları olduğu gibi, bir yavru kedinin de tamamen olgunlaşmış bir kedininkilerden farklı bakım gereksinimleri olacaktır. Buna ek olarak, bir yavru kediye bakarken &ccedil;eşitli gelişim aşamalarını da g&ouml;z &ouml;n&uuml;nde bulundurmalısınız:</p>

<p>Sekiz haftalıktan daha k&uuml;&ccedil;&uuml;k yavru kedilerin bakımı</p>

<p>&nbsp;</p>

<p>&nbsp;Bu erken yaşta, bir yavru kedi &nbsp;annesi ve kardeşleri ile birlikte olmalıdır. Yavru kediler kendi sıcaklıklarını d&uuml;zenleyemedikleri i&ccedil;in hayatta kalmak i&ccedil;in birbirlerinin v&uuml;cut ısısına g&uuml;venirler. Ayrıca hala kemik gelişimleri devam&nbsp; ediyor olacaktır. &nbsp;</p>

<p><br />
<img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/a392122e-0f39-4f21-af3c-4c273e593fcd_3.jpg" style="height:auto !important; width:750px" /></p>

<p>&nbsp;</p>

<h2>Annesinden ayrılmış yavru kedi bakımı</h2>

<p>&nbsp;</p>

<p>Bu yaş grubunda yetim bir kedi yavrusu evlat edinirseniz veya ona bakmak zorundaysanız, d&ouml;rt haftaya kadar her iki saatte bir yavru kediyi biberonla beslemek ve muhtemelen kedinizin işemesine ve kakasına yardımcı olmak da dahil olmak &uuml;zere &ouml;zel dikkat g&ouml;sterilmesi gerekecektir. &Ouml;zel talimatlar ve tavsiyeler i&ccedil;in bir veterinere danışmak en iyisidir.</p>

<p>Sekiz ila on bir haftalık arasında yavru kedilerin bakımı</p>

<p>&nbsp;</p>

<p>Yavru kediler genellikle sekiz haftalıkken s&uuml;tten kesilir ve yoğun enerji &nbsp;veren, protein a&ccedil;ısından zengin ve sindirilebilirliği y&uuml;ksek olan &nbsp;bir &nbsp;kedi maması yemelidir. İster kuru mama ister &nbsp;ıslak mama se&ccedil;in, kedi yavruları i&ccedil;in form&uuml;le edilmiş olduğundan emin olun. Bu d&ouml;nemde başka b&uuml;y&uuml;k değişiklikler de ger&ccedil;ekleşmeye başlayacak. Yavru kediniz karmaşık motor beceriler geliştirmeye başladığında koşmak, zıplamak, oynamak ve keşfetmek isteyecektir. Bu, keyifli bir yavru kedi d&ouml;nemidir, ancak aynı zamanda uygun şekilde denetlenmediği takdirde yavru kediniz i&ccedil;in tehlikeli olabilir. Yavru kediniz i&ccedil;in sınırlar belirlemeye başlayın ve ona nezaret ederken onu g&uuml;venli, kapalı bir odada tutun.</p>

<p><img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/32e675d4-b896-417f-bf50-26604a4ba66a_4.jpg" style="height:auto !important; width:750px" /></p>

<p>&nbsp;</p>

<p>İki ila d&ouml;rt ay arası yavru kedilerin bakımı</p>

<p>&nbsp;</p>

<p>.Bu, yetişkin bir kediden neredeyse &uuml;&ccedil; kat daha fazla enerjiye sahip olacakları yavru kediler i&ccedil;in hızlı bir b&uuml;y&uuml;me aşamasıdır. Bu s&uuml;re zarfında g&uuml;nde &uuml;&ccedil; ila d&ouml;rt &ouml;ğ&uuml;ne ihtiya&ccedil;ları olacak.</p>

<p>D&ouml;rt ila sekiz ay arası yavru kedilerin bakımı</p>

<p>&nbsp;</p>

<p>Bu yaş grubundaki yavru kediler ergenliğe ve dolayısıyla cinsel olgunluğa ulaşıyor. B&ouml;lgesel işaretleme ve istenmeyen gebelik gibi hoş olmayan durumlardan &nbsp;ka&ccedil;ınmak i&ccedil;in, yavru kediniz bu aşamaya gelmeden &ouml;nce kısırlaştırılması hakkında bir veterinerle konuşun. &nbsp;</p>

<p><img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/440714ce-3e50-49cc-b523-d1d1d71ae2c2_5.jpg" style="height:auto !important; width:750px" /></p>

<p>&nbsp;</p>

<h3><strong>2) İyi Davranışı &Ouml;d&uuml;llendirin ve Sosyalleşin, Sosyalleşin, Sosyalleşin</strong></h3>

<p>&nbsp;</p>

<p>Kedinizin yavruluk &nbsp;d&ouml;neminde aldığı sosyalleşme ve eğitim, b&uuml;y&uuml;d&uuml;ğ&uuml;nde insanlarla ve diğer hayvanlarla ne kadar iyi etkileşimde bulunacağını etkileyecektir. &nbsp;Yeni bir yavru kedinin ebeveyni olarak, ona rehberlik etmek ve d&uuml;nyanın harika bir yer olduğunu ona g&ouml;stermek size kalacaktır. Bu eğitim ve sosyalleşme y&ouml;ntemlerinden bazılarını denemeyi d&uuml;ş&uuml;n&uuml;n:</p>

<p>Yavru kediler genellikle i&ccedil;g&uuml;d&uuml;sel olarak kum kaplarını kullanırlar, ancak onu yemeklerden ve oyun seanslarından sonra kutuya koyarak onu kullanmayı &ouml;ğretebilirsiniz. Kum Kabının yavru kediniz i&ccedil;in her zaman mevcut olduğundan ve sık sık temizlendiğinden emin olun.</p>

<p>&nbsp;</p>

<ul>
	<li>Onu sık sık okşayın ve haftalık taramaya alıştırın.</li>
	<li>Onu oyuncaklarla tanıştırın ,farklı y&uuml;r&uuml;me y&uuml;zeylerini deneyimlemesine izin verin .</li>
	<li>Kutular ve kağıt poşetler gibi keşfedeceği nesneler verin.</li>
	<li>Y&uuml;ksek sesli m&uuml;zik &ccedil;alın ve g&uuml;r&uuml;lt&uuml; yapın.</li>
	<li>Arkadaşlarınızı davet edin ve onlardan onunla oynamalarını ve ona &ouml;d&uuml;l mamaları vermelerini isteyin.</li>
	<li>Uygun bir tırmalama tahtası hediye edin &nbsp;ve onu oyuncaklarla &ouml;d&uuml;llendirin, onları kullandığında &ouml;v&uuml;n, &nbsp;</li>
	<li>Oyun sırasında ısırmasına veya tırmalamasına izin vermeyin. B&ouml;yle bir durum varsa dikkatini bir oyuncağa y&ouml;nlendirin.</li>
	<li>Onu diğer kedilerle ve yavru kedilerle tanıştırın (elbette aşı konusunda g&uuml;ncel olduklarında!). &nbsp;Yavru kedinizi araba gezintilerine g&ouml;t&uuml;r&uuml;n, her zaman ona ikramlar verin ve onu kutusuna alıştırın.</li>
	<li>Dost&ccedil;a davranışı, ikramlar veya &ouml;vg&uuml; ile &ouml;d&uuml;llendirin.</li>
	<li>K&ouml;t&uuml; davranışları azarlamayın, bunun yerine uygunsuz davranış sergilediğinde onu g&ouml;rmezden gelin.</li>
	<li>Her zaman sabırlı olun</li>
</ul>

<p>&nbsp;</p>

<p><img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/5f812a94-5eb0-414d-9bb9-d4ec9efc0bdf_6.jpg" style="width:604px" /></p>

<p>&nbsp;</p>

<h3><strong>&nbsp;3) &Ouml;nleyici Bakımı &Ouml;ncelikli Yapın</strong></h3>

<p>&nbsp;</p>

<p>Kedinizin &ouml;m&uuml;r boyu sağlıklı olmasını sağlamaya yardımcı olmak i&ccedil;in ona &ouml;nleyici bakım sağlamaya erken başlayın:</p>

<p>Ne olursa olsun, yavru kedinizin ilk veteriner randevusunu, onu aldıktan sonraki bir hafta i&ccedil;inde planlayın. Erken ve sık veteriner ziyaretleri, yavru kedinizin veterinerle sosyalleşmesine ve veterinerin yavru kedinizin sağlığı i&ccedil;in bir temel oluşturmasına yardımcı olacaktır.</p>

<p>Bağırsak parazitleri, pireler ve kalp kurdu hakkında bilgi alın. Bir veterinerin yavru kedinizi solucanlar ve bağırsak parazitleri a&ccedil;ısından kontrol etmesini sağlayın ve gerekirse i&ccedil; dış parazit tedavisi yaptırın.. Ve kalp kurtları kediler i&ccedil;in k&ouml;pekler kadar sorun olmasa da, bazı yavru kediler duyarlı olabilir, bu nedenle veterinerinize bir kalp kurdu &ouml;nleyici tavsiye edip etmediğini sorun. Bununla birlikte, yavru kediniz i&ccedil;in en b&uuml;y&uuml;k asalak tehdit piredir. Yavru kediniz yaklaşık 8 ila 12 haftalıkken bitkisel pire &ouml;nleyici uygulamaya başlayabilirsiniz - ancak bazı markalar 4 haftalık yavru kediler i&ccedil;in form&uuml;le edilmiştir.</p>

<p><img alt="patiliyo.com" src="https://patiliyo.com/Upload/Contents/dec3260d-12ef-46a6-abc1-ebc5d9024761_7.jpg" style="height:450px; width:600px" /></p>

<p>&nbsp;</p>

<p>Yavru kedinizin hangi aşılara ihtiyacı olduğunu ve ne sıklıkta olduğunu sorun: Yavru kediler i&ccedil;in koruyucu bakım, kedi l&ouml;semi, kuduz ve distemper aşılarını i&ccedil;erebilir. Bu aşılar genellikle ilk olarak bir yavru kedi yaklaşık 8 haftalıkken uygulanır ve 16 haftalık olana kadar birka&ccedil; haftada bir yapılır. Bundan sonra, veterineriniz onu yetişkinler i&ccedil;in bir aşı programı ayarlayabilir. Ayrıca ek aşı &ouml;nerebilir.</p>
', CAST(N'2022-01-05T01:41:25.0000000' AS DateTime2), N'569eb4b3-d703-4a95-a2ef-f8cec2589f5e-05January2022-12asas.jpg', N'a6ba4fa1-55ee-4bb8-a926-128f6f009913', N'Yavru Kedi Bakımı Hakkında Bilmeniz Gereken İpuçları')
INSERT [dbo].[Blogs] ([Id], [Title], [Text], [CreatedDate], [Image], [CustomUserId], [BlogInfo]) VALUES (14, N'API Nedir? API Nedir? API Nedir?', N'<p>Teknik anlamda API (Application Programming Interface) kelimelerinin kısaltılması olarak s&ouml;ylenen ve dilimizde &ldquo;Uygulama Programlama Aray&uuml;z&uuml;&rdquo; olarak bilinen, bir uygulamanın işlevlerine dışarıdan veya uzaktan erişilip bu işlevlerin kullanılmasını sağlayan aray&uuml;zd&uuml;r. API, web uygulaması, işletim sistemi, veri tabanı, donanımlar yahut yazılım k&uuml;t&uuml;phanesi i&ccedil;in kullanılabilir.</p>

<p>&nbsp;</p>

<p>API, bir sunucunun &uuml;zerindeki uygulamaya farklı platformlardan ulaşılmasını ve yanıt vermesine&nbsp;olanak sağlar. Web API&rsquo;lerinin tamamı REST (Representational State Transfer) mimarisi &uuml;zerinde dizayn edilir. Bundan dolayı platform bağımsız &ccedil;alışır. Bu mimari GET, POST, PUT, DELETE metotlarının hepsini desteklemektedir. Web API &ccedil;ıktıları talebe g&ouml;re JSON, XML gibi &ccedil;eşitli &ccedil;ıktıları olabilir.<br />
&nbsp;</p>

<h2>API Nasıl Kullanılır?</h2>

<p><br />
API&#39;ler genellikle&nbsp;<a href="https://www.biltektasarim.com/hizmet/web-yazilim"><strong>web geliştiricileri</strong></a>&nbsp;ve program geliştiricileri tarafından kullanılmaktadır. Bir programın farklı bir servisin &ouml;zelliğinden de faydalanması gerektiği zamanlarda API kullanarak bu fonksiyonların tam olarak yerine getirilmesi gereklidir. API kullanımın asıl amacı bir uygulamanın b&uuml;t&uuml;n veya bazı metotlarını diğer uygulamalara kullanıma a&ccedil;arak uzaktan gelecek veri ve bilgi taleplerini kolayca ve hızlıca karşılamaktadır. API&rsquo;ler otomasyon imkanı verir, s&uuml;re&ccedil;leri hızlandırmayı, programatikleştirmeyi saglar.</p>

<h2>API &Ouml;rnekleri</h2>

<p>Sizinle etkileşime girebilecek, pek &ccedil;ok sekt&ouml;rden bir&ccedil;ok ortak Application Programming Interface (API) bulunur. Bazı platform şirketlerinin kodlarına bir API &uuml;zerinden programlı olarak erişebilme yeteneği, temelde onları bir platform yapan şeydir. Bazı belirgin API &ouml;rnekleri şunları i&ccedil;erir:</p>

<p>Kodunuzu Google Haritalar hizmetinden t&uuml;m Google hizmetlerine bağlayabilmenizi sağlayan Google API&rsquo;leri. API&rsquo;ler Google i&ccedil;in &ccedil;ok &ouml;nemlidir ve lider bir API y&ouml;netim platformu olan Apigee&rsquo;yi satın almışlardır.<br />
Facebook&rsquo;un sosyal grafik ve pazarlama ara&ccedil;larına programlı olarak erişmenizi sağlayan Facebook API&rsquo;leri. (Şirket, Cambridge Analytica ve diğer skandallardan kaynaklanan bu API&rsquo;ler &uuml;zerinden erişebildiğiniz kullanıcı verilerini kısıtlamaktadır.)</p>
', CAST(N'2022-01-05T03:40:24.2813095' AS DateTime2), N'4c0e82a8-e94a-4b4e-a0ed-d04ddf660f66-05January2022-api.jpeg', N'bcb814aa-da99-4bc4-8ea7-5783f79d4a5b', N'API (Application Programming Interface)')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[CommentPosts] ON 

INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (27, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'Salam millet!')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (28, N'Rasul', N'abdulovrasul@bk.ru', NULL, N'Salam Orxan menem Resul')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (31, N'Elxan', N'ASJa@mail.ru', NULL, N'Axshamiviz xeyir')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (36, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'Salam Usaglar Axshamivuz xeyir olsun!')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (39, N'Orkhan', N'amirovorxan@gmail.com', N'Hello1', N'akjhsakjsh')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (40, N'Ashraf', N'Ashraf500@mail.ru', NULL, N'Bu nedi ala?')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (41, N'Elxan', N'ASJa@mail.ru', NULL, N'Imana gelin ey camaat')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (42, N'Rasul', N'abdulovrasul@bk.ru', NULL, N'nolub ay qa?')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (43, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'Nolub ?')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (46, N'Orkhan', N'amirovorxan@gmail.com', N'Hello1', N'Salam Qardashlar')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (80, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'Salam')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (84, N'Ashraf', N'Ashraf500@mail.ru', NULL, N'Test2')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (86, N'Orkhan', N'amirovorxan@gmail.com', N'ashdkjah', N'aldkjsakldh')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (87, N'Ashraf', N'Ashraf500@mail.ru', NULL, N'asldkjaslkd')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (88, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'aslkdjaskljd')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (89, N'Rasul', N'abdulovrasul@bk.ru', NULL, N'ad;lksls')
INSERT [dbo].[CommentPosts] ([Id], [FullName], [Email], [Subject], [Content]) VALUES (90, N'Orkhan', N'amirovorxan@gmail.com', NULL, N'Elvin artirmisanaaa')
SET IDENTITY_INSERT [dbo].[CommentPosts] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (24, N'Salam millet!', CAST(N'2020-12-25T23:19:42.0000000' AS DateTime2), NULL, 1, 27)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (25, N'Salam Orxan menem Resul', CAST(N'2021-12-25T23:21:01.5179341' AS DateTime2), 24, 1, 28)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (28, N'Axshamiviz xeyir', CAST(N'2021-12-26T01:59:36.6810455' AS DateTime2), 24, 1, 31)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (35, N'Salam Usaglar Axshamivuz xeyir olsun!', CAST(N'2021-12-26T05:12:50.0102067' AS DateTime2), NULL, 2, 36)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (38, N'akjhsakjsh', CAST(N'2021-12-26T05:20:11.4616475' AS DateTime2), NULL, 3, 39)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (39, N'Bu nedi ala?', CAST(N'2021-12-26T05:24:57.9484676' AS DateTime2), 38, 3, 40)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (40, N'Imana gelin ey camaat', CAST(N'2021-12-26T05:26:12.3700903' AS DateTime2), NULL, 3, 41)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (41, N'nolub ay qa?', CAST(N'2021-12-26T05:26:34.4269776' AS DateTime2), 40, 3, 42)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (42, N'Nolub ?', CAST(N'2021-12-26T05:58:05.9005771' AS DateTime2), 38, 3, 43)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (43, N'Salam Qardashlar', CAST(N'2021-12-27T02:13:40.2895649' AS DateTime2), NULL, 3, 46)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (67, N'aldkjsakldh', CAST(N'2022-01-04T20:25:16.1052784' AS DateTime2), NULL, 11, 86)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (68, N'asldkjaslkd', CAST(N'2022-01-04T20:25:26.1223184' AS DateTime2), 67, 11, 87)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (69, N'aslkdjaskljd', CAST(N'2022-01-04T20:25:34.6578716' AS DateTime2), 67, 11, 88)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (70, N'ad;lksls', CAST(N'2022-01-04T20:25:43.8966750' AS DateTime2), NULL, 11, 89)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [BlogId], [CommentPostId]) VALUES (71, N'Elvin artirmisanaaa', CAST(N'2022-01-05T03:42:36.2515323' AS DateTime2), NULL, 14, 90)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Restourants] ON 

INSERT [dbo].[Restourants] ([Id], [Name], [Address], [Text], [ReceptionPhone], [CompaintPhone], [SupportPhone], [LocationOnMap], [OpeningTime], [ClosingTime], [Logo], [LocationDesc], [ManagerEmail], [ManagerImage], [ManagerName], [ManagerPhone], [ManagerSurName], [ManagerWebSite]) VALUES (27, N'Shaurma N1', N'NƏSİMİ RAYONU, A. BAKIXANOV EV R. BEHBUDOV KÜÇ KƏSİŞMƏSİ', N'1998 - ci ilə dayanır bizim dadlı tarixçəmiz.Kiçik bir məkanda, balaca komanda ilə, fəaliyyətə başladıq və qısa bir müddətdə tam keyfiyyətli xidmət göstərərək, ailəvi restorana çevrildik. Hal - hazırda 20-dən çox filialla xidmətinizdəyik! İstifadə etdiyimiz məhsulların keyfiyyətli və təzə olması bizim üçün ən vacib amillərdən biridir. Nəzərinizə çatdıraq ki, aldığımız məhsulların saxlanma şəraitinə də xüsusi diqqət yetirilir. Əməkdaşlarımız tərəfindən ərzaq məhsullarının saxlandığı soyuducu və anbarlara daima nəzarət olunur. Onu da qeyd edək ki, xəstəlik mənbəyi ola biləcək virus və bakteriyaların məhv edilməsi üçün, restoranımızda mütəmadi olaraq dezinfeksiya işləri aparılır.', N'+99412 493 33 06', N'+99451 911 22 11', N'+99451 911 22 22', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d4361.036160897007!2d49.83515648792378!3d40.375440635956046!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307db03d88acab%3A0xd689d335d81090a7!2zU2hhdXJtYSDihJYx!5e0!3m2!1sen!2s!4v1641224839703!5m2!1sen!2s', CAST(N'2022-01-03T08:00:00.0000000' AS DateTime2), CAST(N'2022-01-03T23:00:00.0000000' AS DateTime2), N'595465ca-d876-41ca-9f4c-8db689a56ca8-03January2022-shaurma1.png', N'Restoranlar', N'Amirovorxan@gmail.com', N'a168973d-acac-45e9-86e4-52b4ad5decbd-03January2022-214899863.jpg', N'Orkhan', N'+994705888828', N'Amirli', N'Amirli.az')
INSERT [dbo].[Restourants] ([Id], [Name], [Address], [Text], [ReceptionPhone], [CompaintPhone], [SupportPhone], [LocationOnMap], [OpeningTime], [ClosingTime], [Logo], [LocationDesc], [ManagerEmail], [ManagerImage], [ManagerName], [ManagerPhone], [ManagerSurName], [ManagerWebSite]) VALUES (28, N'Chinar', N'Şövkət Ələkbərov 1 İçərişəhər', N'Gül ekşili çorba cezbelendi domates patlıcan koyun. Gitti de mutlu oldular sarmal açılmadan dolayı hesap makinesi cezbelendi koşuyorlar sevindi koyun hesap makinesi. Mutlu oldular batarya kutusu koştum mutlu oldular de. Göze çarpan umut göze çarpan batarya kutusu dışarı çıktılar gitti gül ışık dağılımı beğendim karşıdakine. Duyulmamış bundan dolayı de uzattı şafak öyle ki sevindi mutlu oldular koştum. Kapının kulu sinema ötekinden dolayı de ve. Kapının kulu türemiş sıfat sevindi çakıl dergi. Çakıl gazete ona doğru türemiş sıfat duyulmamış yazın masaya doğru adanaya düşünüyor yazın koyun sandalye. Nedirnedemek Türkçe Lorem İpsum.', N'42342332', N'234234243', N'012 404 8211', N'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24321.439638497224!2d49.832957!3d40.360534!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x4325348f95e0adf5!2sCHINAR!5e0!3m2!1sen!2sus!4v1641252446840!5m2!1sen!2sus', CAST(N'2022-01-04T12:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'13e9f38b-e806-422b-85fe-67087024043c-04January2022-chinar.jpg', N'Türemiş sıfat gazete çakıl yapacakmış göze çarpan biber kapının kulu telefonu telefonu bahar. Ona doğru hesap makinesi gitti düşünüyor sıradanlıktan. Domates batarya kutusu duyulmamış çobanın beğendim tv gül ışık dağılımı un değirmeni türemiş sıfat gül bundan dolayı lambadaki de.', N'mehdiyevilham@gmail.com', N'2333e1e6-64e2-4711-b75d-1620fa159eb3-04January2022-team-21.jpg', N'Ilham', N'+994514544464', N'Mehdiyev', N'Chinar.az')
INSERT [dbo].[Restourants] ([Id], [Name], [Address], [Text], [ReceptionPhone], [CompaintPhone], [SupportPhone], [LocationOnMap], [OpeningTime], [ClosingTime], [Logo], [LocationDesc], [ManagerEmail], [ManagerImage], [ManagerName], [ManagerPhone], [ManagerSurName], [ManagerWebSite]) VALUES (29, N'Sumakh', N'20/22 Xocalı Xətai', N'27 fevral tarixində Azərbaycanın ənənəvi mətbəxini təqdim edən ən yaxşı restoranlarında biri Sumakh kiçik təmirdən sonra qapılarını öz qonaqlarının üzünə açdı. Yenilənmə tək restoranın genişləndirdiyimiz interyerini və təzələdiyimiz dekoruna deyil, həmçinin menyuya da aid oldu. Menyumuzda yeməklər və onların təqdimatı da əhəmiyyətli dərəcədə yeniləndi. Uzun sözün qısası - az danışmaq, çox işləmək lazımdır: gəlin və özünüz əmin olun!', N'012 480 2112', N'012 480 2112', N'012 480 2112', N'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12156.85247218728!2d49.868427!3d40.381969!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xc80ab7ea6e7a3a6b!2sSumakh!5e0!3m2!1sen!2sus!4v1641252948620!5m2!1sen!2sus', CAST(N'2022-01-04T12:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'4bff3625-8ab6-4bd4-b947-cac3c4da9572-04January2022-Sumakh.jpg', N'Çakıl ötekinden dolayı tv bahar dışarı çıktılar cezbelendi bilgisayarı düşünüyor salladı un değirmeni sevindi filmini mi gördüm duyulmamış.', N'muradov@gmail.com', N'7464bf6c-f8e8-469c-9cce-4cacb9fe98cf-04January2022-team-15.jpg', N'Ilqar', N'+994557888898', N'Muradov', N'Sumakh.az')
INSERT [dbo].[Restourants] ([Id], [Name], [Address], [Text], [ReceptionPhone], [CompaintPhone], [SupportPhone], [LocationOnMap], [OpeningTime], [ClosingTime], [Logo], [LocationDesc], [ManagerEmail], [ManagerImage], [ManagerName], [ManagerPhone], [ManagerSurName], [ManagerWebSite]) VALUES (30, N'MariVanna', N'93, Zərifə Əliyeva Sahil', N'Çobanın kapının kulu mutlu oldular adanaya yapacakmış layıkıyla batarya kutusu eve doğru masanın biber öyle ki cezbelendi. Koştum göze çarpan batarya kutusu sıradanlıktan mutlu oldular karşıdakine cezbelendi layıkıyla duyulmamış ışık dağılımı. Lambadaki öyle ki türemiş sıfat çakıl layıkıyla bilgiyasayarı lakin koşuyorlar değerli olduğu için cesurca yaptı. Değerli olduğu için filmini mi göze çarpan lambadaki layıkıyla.', N'050 256 44 29', N'050 256 44 29', N'050 256 44 29', N'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24317.028014199095!2d49.849311!3d40.372761!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xa6b901084ed418e5!2sMari%20Vanna!5e0!3m2!1sen!2sus!4v1641254404454!5m2!1sen!2sus', CAST(N'2022-01-04T10:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'6f4d69ae-7465-423e-ae08-a3cf1728e8a2-04January2022-Marivanna.jpg', N'Gülüyorum yazın masaya doğru gül ekşili çorba koştum cezbelendi teldeki cezbelendi kapının kulu bilgiyasayarı lambadaki filmini mi uzattı. Teldeki cesurca yaptı çobanın gülüyorum sıradanlıktan orta camisi telefonu layıkıyla bundan dolayı adanaya.', N'narmin@gmail.com', N'72983d27-2b08-4ac6-a9a8-daa49fddaf4c-04January2022-team-14.jpg', N'Narmin', N'+994709999829', N'Imanli', N'MariVanna.az')
INSERT [dbo].[Restourants] ([Id], [Name], [Address], [Text], [ReceptionPhone], [CompaintPhone], [SupportPhone], [LocationOnMap], [OpeningTime], [ClosingTime], [Logo], [LocationDesc], [ManagerEmail], [ManagerImage], [ManagerName], [ManagerPhone], [ManagerSurName], [ManagerWebSite]) VALUES (31, N'Black', N'Abdulla Şaiq 241 Nizami', N'Ve kapının kulu düşünüyor ve bahar telefonu değerli olduğu için gül uzattı patlıcan bundan dolayı anlamsız cesurca yaptı dışarı çıktılar. Yapacakmış yazın gidecekmiş telefonu çünkü. Orta camisi masanın batarya kutusu ona doğru mutlu oldular gülüyorum türemiş sıfat tv yapacakmış sıla. Gülüyorum bilgiyasayarı koştum otobüs masanın balıkhaneye gördüm öyle ki sinema karşıdakine duyulmamış layıkıyla umut. Cezbelendi balıkhaneye değerli olduğu için beğendim uzattı. Anlamsız batarya kutusu çakıl yazın türemiş sıfat. Duyulmamış dışarı çıktılar cezbelendi gül umut sinema göze çarpan ışık dağılımı bahar masaya doğru. Nedirnedemek Türkçe Lorem İpsum.', N'050 400 1040', N'050 400 1040', N'050 400 1040', N'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24312.961065258707!2d49.822109!3d40.38403!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x2c0380ffa0a0cfd9!2sBlack%20Lounge!5e0!3m2!1sen!2sus!4v1641254897382!5m2!1sen!2sus', CAST(N'2022-01-04T15:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'a82d0be7-eb25-4fef-ba06-6c0ce69a01da-04January2022-black.jpg', N'Bilgisayarı cesurca yaptı ışık dağılımı sokaklarda filmini mi lakin uzattı yapacakmış teldeki ekşili çorba orta camisi sinema de kapının kulu.', N'ayselk@gmail.com', N'2c2a327e-f54d-4ed7-9f98-05127c897c79-04January2022-team-22.jpg', N'Aysel', N'+994104101001', N'Karimzade', N'Black.az')
SET IDENTITY_INSERT [dbo].[Restourants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestourantComments] ON 

INSERT [dbo].[RestourantComments] ([Id], [Content], [CreatedDate], [RestourantId], [CommentPostId]) VALUES (13, N'Salam', CAST(N'2022-01-04T03:56:33.1110415' AS DateTime2), 29, 80)
INSERT [dbo].[RestourantComments] ([Id], [Content], [CreatedDate], [RestourantId], [CommentPostId]) VALUES (17, N'Test2', CAST(N'2022-01-04T04:52:21.7783586' AS DateTime2), 31, 84)
SET IDENTITY_INSERT [dbo].[RestourantComments] OFF
GO
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (1, N'One')
INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (2, N'Two')
INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (3, N'Three')
INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (4, N'Four')
INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (5, N'Five')
INSERT [dbo].[Guests] ([Id], [GuestCount]) VALUES (7, N'Six')
SET IDENTITY_INSERT [dbo].[Guests] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [Name], [Surname], [IdentityNo], [Phone], [ReservationTime], [GuestId], [RestourantId], [CreatedDate]) VALUES (9, N'Orkhan', N'Amirli', N'az123123', N'9342937', CAST(N'2022-01-13T00:00:00.0000000' AS DateTime2), 2, 31, CAST(N'2022-01-04T06:36:34.3541712' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
SET IDENTITY_INSERT [dbo].[RestourantFeatures] ON 

INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (1, N'Feature1')
INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (2, N'Feature2')
INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (3, N'Feature3')
INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (4, N'Feature4')
INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (5, N'Feature5')
INSERT [dbo].[RestourantFeatures] ([Id], [Name]) VALUES (6, N'Feature6')
SET IDENTITY_INSERT [dbo].[RestourantFeatures] OFF
GO
SET IDENTITY_INSERT [dbo].[RestourantFeatureToRestourants] ON 

INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (31, 1, 27)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (32, 2, 27)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (33, 3, 27)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (36, 6, 28)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (37, 3, 28)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (38, 1, 28)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (39, 5, 29)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (40, 3, 29)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (41, 1, 29)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (44, 3, 30)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (45, 2, 30)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (46, 6, 31)
INSERT [dbo].[RestourantFeatureToRestourants] ([Id], [RestourantFeatureId], [RestourantId]) VALUES (47, 4, 31)
SET IDENTITY_INSERT [dbo].[RestourantFeatureToRestourants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestourantTags] ON 

INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (1, N'tag1')
INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (2, N'tag2')
INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (3, N'tag3')
INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (4, N'tag4')
INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (5, N'tag5')
INSERT [dbo].[RestourantTags] ([Id], [Name]) VALUES (6, N'tag6')
SET IDENTITY_INSERT [dbo].[RestourantTags] OFF
GO
SET IDENTITY_INSERT [dbo].[RestourantTagToRestourants] ON 

INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (37, 1, 27)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (38, 2, 27)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (39, 3, 27)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (42, 1, 28)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (43, 2, 28)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (44, 4, 28)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (45, 3, 29)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (46, 4, 29)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (47, 5, 29)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (50, 1, 30)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (51, 4, 30)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (52, 1, 31)
INSERT [dbo].[RestourantTagToRestourants] ([Id], [RestourantTagId], [RestourantId]) VALUES (53, 6, 31)
SET IDENTITY_INSERT [dbo].[RestourantTagToRestourants] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (1, N'Pomidor Yumurta')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (2, N'Kabab Tike')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (3, N'Kabab Lule')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (4, N'Kabab Toyuq')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (5, N'Piti')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (6, N'Basdirma')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (7, N'Salat')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (8, N'MerciSupu')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (10, N'Shaurma (Corekde)')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (11, N'Relaks boşqabı çinar (4-6 nəfərlik)')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (12, N'Xəzər kürüsü ilə draqon suşi roll')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (13, N'Vaqyu steyki şərq göbələkləri ilə')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (15, N'Şəki pitisi')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (16, N'Əriştə')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (17, N'Marivana london`dan ingilis sayağı səhər yeməyi')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (18, N'Doyumlu milli sәhәr yemәyi')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (19, N'Omlet və ya qayğanaq')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (20, N'Ev sayağı kәsmikli kekslәr')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (21, N'Göbələkli qaymaqlı şorba')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (22, N'Qırmızı mərci')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (23, N'Tom yam')
INSERT [dbo].[Menu] ([Id], [MenuName]) VALUES (24, N'Toyuq frikadelləri ilə əriştəli şorba')
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuToRestourants] ON 

INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (14, N'Şafak domates sıradanlıktan balıkhaneye koşuyorlar dışarı çıktılar ekşili çorba teldeki kapının kulu salladı sıradanlıktan göze çarpan filmini mi değerli olduğu için.', 240, 28, 11)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (15, N'Bundan dolayı layıkıyla bundan dolayı bundan dolayı şafak türemiş sıfat.', 120, 28, 12)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (16, N'Masanın sokaklarda batarya kutusu adresini çobanın de hesap makinesi koşuyorlar öyle ki.', 150, 28, 13)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (17, N'quyruq, noxud, albuxara və kartof ilə birlikdə bardagda bişirilmiş qoyun əti', 10, 29, 5)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (18, N'Quyruq, noxud, albuxara, qoyun əti və şabalıd', 11, 29, 15)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (20, N'ev əriştəsi ilə toyuq ətindən küftələr əlavə edilmiş şorba', 8, 29, 16)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (21, N'10:00-14:00 həftəsonu ac insan üçün doyumlu səhər yeməyi: qayğanaq, ev sayağı kartoşka, sosislər, miks-salat, bekon, göbələk və lobya tomat sousunda', 20, 30, 17)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (22, N'10:00`dan 14:00 kimi həftəsonu. kükü vә yaxud pomidor–yumurta seçim sizindir, üstә gәl bol: çörәk, yağ, pendir vә qozomlet vә ya qayğanaq 3 yumurta öz ağız dadınıza uyğun seçin', 15, 30, 18)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (23, N'10:00 — 14:00 şənbə və bazar. 3 yumurta. öz dadınıza uyğun seçin: vetçina mal, bekon', 9, 30, 19)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (25, N'qədim avropa reseptinə uyğun olaraq qaymaq və ədviyyatlar ilə vam odda hazırlanmış göbələkli və tərəvəzli ləziz şorba. krutonlar ilə verilir', 6, 31, 21)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (26, N'ədviyyatlar ilə seçilmiş qırmızı mərci, dadlı pomidor və tərəvəzlərdən vam odaa hazırlanmış ləziz şorba. limon və krutonlar ilə verilir', 5, 31, 22)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (27, N'ocaqda qızardılmış krevet və tərəvəzlərlə hazırlanmış zəngin dadlı acı-turş tay supu. müştərinin arzusu ilə, daha çox dəniz məhsulları əlavə oluna bilər', 12, 31, 23)
INSERT [dbo].[MenuToRestourants] ([Id], [Ingrediend], [Price], [RestourantId], [MenuId]) VALUES (28, N'ədviyyatlı toyuq bulyonunda hazırlanmış toyuq frikadelləri, göbələklər və ev əriştəsi', 6, 31, 24)
SET IDENTITY_INSERT [dbo].[MenuToRestourants] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211223221837_First_Init', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211224211209_Second_Init', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211224211729_Third-Init', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211225010637_added_Required', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211225132702_allowNuls', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211225165314_init6', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211225173334_init7', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211225223653_added-required', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211226213923_added_RestourantIdToCommentPostForPassingData', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211227000226_blablabla', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211227020540_asasas', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211228094627_addedRequired', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211229163350_added_required2', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211229163853_added_required3', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211229203739_added_required4', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211230173327_added_required5', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211230223923_addedrequired6', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211230233014_addedrequired7', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211231024942_addedrequired8', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102082829_added_required8', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102091921_added_required9', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102100326_added_required10', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102110624_added_required11', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102113539_added_required12', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102123328_Added_restouranttagtorestourantid', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102144457_Added_restourantfeaturetorestourantid', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220102222313_added_MenuToRestourantId', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220103004006_added_required13', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220103030834_Editing_somethings', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220104180316_lastTouches', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220104180401_lastTouches2', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220104182656_lastrequiredadded', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220104223329_senolbuaxrincidi', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220104223530_12312-ci', N'5.0.13')
GO
SET IDENTITY_INSERT [dbo].[AboutUs] ON 

INSERT [dbo].[AboutUs] ([Id], [Icon], [Info], [ImageText], [Image]) VALUES (4, N'fa fa-info', N'Layıkıyla masanın gitti değerli olduğu için biber. Sarmal açılmadan dolayı duyulmamış filmini mi sevindi batarya kutusu. Lakin çobanın un değirmeni patlıcan eve doğru gülüyorum ama bahar mutlu oldular sokaklarda ışık dağılımı kalemi sandalye. Ama hesap makinesi domates orta camisi balıkhaneye koştum. Cesurca yaptı şafak gazete öyle ki sokaklarda adanaya çobanın sandalye adresini ona doğru ötekinden dolayı patlıcan koyun. Nedirnedemek Türkçe Lorem İpsum.', N'Uzattı göze çarpan ışık dağılımı yapacakmış eve doğru salladı sokaklarda telefonu öyle ki adresini beğendim de ve. Duyulmamış gazete uzattı sokaklarda adanaya lambadaki uzattı duyulmamış kapının kulu çünkü anlamsız karşıdakine.', N'e7bf6bc3-8470-4bc2-aed7-15f24ba8d58c-31December2021-about-image.jpg')
SET IDENTITY_INSERT [dbo].[AboutUs] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (1, N'Explore your search places', N'About Us', N'About', N'e93c5bbd-fc86-4c2b-8db5-ed7976bbc0ad-30December2021-title-bar.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (2, N'Explore your search places', N'Contact Us', N'Contact', N'd3c8a25a-efc5-4d4b-9c27-8797e394053c-04January2022-title-bar.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (3, N'Explore your search places', N'Blog Detail', N'Blog Detail', N'b081c08a-bef2-40b5-8442-aa57f5de6d01-04January2022-title-bar.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (6, N'Explore New Places', N'Restourants', N'Restourants', N'9952f8ae-d581-4a7d-a26e-120fd62aaa90-04January2022-title-bar.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (7, N'Explore New Places', N'Restourant', N'Restourant', N'b61a6cb1-a669-4481-a327-4d1a285849bf-04January2022-title-bar.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (8, N'Explore your search places', N'Blogs', N'Blog', N'28fd7034-e92b-42dc-8ac9-60f1071e0414-04January2022-title-bar.jpg')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[ContactUs] ON 

INSERT [dbo].[ContactUs] ([Id], [Address], [Phone], [Email]) VALUES (4, N'Aerbaijan/ Baku/ Khazar/ Kh.Natavan no 33', N'+994502115545', N'amirovorxan@gmail.com')
SET IDENTITY_INSERT [dbo].[ContactUs] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([Id], [FirstName], [LastName], [Email], [Subject], [Content], [CreatedDate]) VALUES (6, N'Orkhan', N'Amirli', N'Amirovorxan@gmail.com', N'Subject 1', N'Şafak sandalye batarya kutusu salladı koyun hesap makinesi ama koşuyorlar sıla. Patlıcan ama çobanın gazete bundan dolayı batarya kutusu dışarı çıktılar teldeki balıkhaneye mıknatıslı okuma sayfası düşünüyor çakıl öyle ki yapacakmış. Yazın duyulmamış filmini mi eve doğru uzattı sevindi bundan dolayı kapının kulu sıradanlıktan çünkü. Gördüm koştum beğendim telefonu değerli olduğu için gülüyorum. Umut teldeki patlıcan öyle ki karşıdakine kalemi. Nedirnedemek Türkçe Lorem İpsum.', CAST(N'2021-12-30T20:58:38.1221985' AS DateTime2))
INSERT [dbo].[Messages] ([Id], [FirstName], [LastName], [Email], [Subject], [Content], [CreatedDate]) VALUES (7, N'Ashraf', N'Abdulov', N'Abdulov@gmail.com', N'Subject 2', N'De patlıcan bundan dolayı karşıdakine gitti eve doğru gidecekmiş gül de değerli olduğu için. Cezbelendi koştum sevindi kapının kulu batarya kutusu. Adanaya salladı cesurca yaptı kapının kulu gitti cezbelendi göze çarpan sandalye biber gördüm. Ama ışık dağılımı biber domates türemiş sıfat çakıl. Düşünüyor masaya doğru göze çarpan gitti filmini mi de bilgisayarı duyulmamış uzattı umut bilgisayarı bilgiyasayarı masaya doğru. Dergi değerli olduğu için umut sinema gördüm çünkü çobanın çobanın un değirmeni duyulmamış. Nedirnedemek Türkçe Lorem İpsum.', CAST(N'2021-12-30T20:59:24.4659591' AS DateTime2))
INSERT [dbo].[Messages] ([Id], [FirstName], [LastName], [Email], [Subject], [Content], [CreatedDate]) VALUES (8, N'Rasul', N'Abdulov', N'RasulAbdulov@gmail.com', N'Subject 3', N'Batarya kutusu sarmal açılmadan dolayı sokaklarda koşuyorlar cezbelendi ekşili çorba koşuyorlar patlıcan masaya doğru göze çarpan cezbelendi filmini mi karşıdakine gidecekmiş. Koştum çünkü telefonu sıradanlıktan sinema. Çakıl salladı öyle ki gördüm gülüyorum. Öyle ki koyun yapacakmış sinema bilgisayarı sandalye koyun çünkü otobüs hesap makinesi. De un değirmeni mutlu oldular beğendim kalemi tv gülüyorum adanaya ve cezbelendi ona doğru lambadaki. Masanın tv çobanın gördüm göze çarpan domates balıkhaneye çakıl sıla umut çünkü layıkıyla batarya kutusu. Balıkhaneye gördüm öyle ki bundan dolayı göze çarpan öyle ki balıkhaneye bundan dolayı cezbelendi sandalye sevindi hesap makinesi gülüyorum. Nedirnedemek Türkçe Lorem İpsum.', CAST(N'2021-12-30T20:59:55.1330148' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
SET IDENTITY_INSERT [dbo].[Plans] ON 

INSERT [dbo].[Plans] ([Id], [Title], [Text], [Icon]) VALUES (4, N'Find Interesting Place', N'Gül gazete adresini sokaklarda dergi domates beğendim sokaklarda batarya kutusu sevindi kalemi adresini sinema bundan dolayı.', N'fa fa-search')
INSERT [dbo].[Plans] ([Id], [Title], [Text], [Icon]) VALUES (5, N'Contact a Few Owners', N'Mıknatıslı okuma sayfası lakin batarya kutusu salladı düşünüyor çobanın duyulmamış koyun biber ekşili.', N'fa fa-phone-square')
INSERT [dbo].[Plans] ([Id], [Title], [Text], [Icon]) VALUES (6, N'Make a Reservation', N'Balıkhaneye adanaya hesap makinesi ekşili çorba sinema dergi gidecekmiş cesurca yaptı telefonu ve ona doğru gördüm patlıcan.', N'fa fa-user-plus')
SET IDENTITY_INSERT [dbo].[Plans] OFF
GO
SET IDENTITY_INSERT [dbo].[Processes] ON 

INSERT [dbo].[Processes] ([Id], [Title], [Text], [Icon]) VALUES (4, N'Plan', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo', N'fa fa-bookmark')
INSERT [dbo].[Processes] ([Id], [Title], [Text], [Icon]) VALUES (5, N'Code', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod', N'fa fa-rocket')
INSERT [dbo].[Processes] ([Id], [Title], [Text], [Icon]) VALUES (6, N'Deliver', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod', N'fa fa-check')
SET IDENTITY_INSERT [dbo].[Processes] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [FooterText], [Phone], [Email], [Address], [BgImage]) VALUES (9, N'd2601566-e4d1-4aaa-8634-d3dcbc588f50-29December2021-logo-white.png', N'Morbi convallis bibendum urna ut viverra. Maecenas quis consequat libero, a feugiat eros. Nunc ut lacinia tortor morbi ultricies laoreet ullamcorper phasellus semper.', N'+994705888828', N'amirovorxan@gmail.com', N'Little Lonsdale St, Melbourne12345', N'7ee0ada3-5396-4400-a0b4-ac258ac157da-29December2021-bw-3.jpg')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteSocials] ON 

INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (1, N'Facebook', N'#', N'fa fa-facebook-square')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (2, N'Twitter', N'#', N'fa fa-twitter')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (3, N'Dribbble', N'#', N'fa fa-dribbble')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (4, N'GitHub', N'#', N'fa fa-github')
SET IDENTITY_INSERT [dbo].[SiteSocials] OFF
GO
