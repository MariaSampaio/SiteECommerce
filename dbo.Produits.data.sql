﻿SET IDENTITY_INSERT [dbo].[Produits] ON
INSERT INTO [dbo].[Produits] ([IdProduit], [NomProduit], [ImgProduit], [PrixProduit], [DescriptionProduit], [Marque_IdMarque], [Categorie_IdCategorie], [Commande_Id], [Fournisseurs_Idfournisseur]) VALUES (1, N'Savon', N'img', CAST(15.00 AS Decimal(18, 2)), N'naturel', 2, 2, NULL, NULL)
INSERT INTO [dbo].[Produits] ([IdProduit], [NomProduit], [ImgProduit], [PrixProduit], [DescriptionProduit], [Marque_IdMarque], [Categorie_IdCategorie], [Commande_Id], [Fournisseurs_Idfournisseur]) VALUES (2, N'Shampoing', N'img', CAST(12.00 AS Decimal(18, 2)), N'chimique', 2, 3, NULL, NULL)
INSERT INTO [dbo].[Produits] ([IdProduit], [NomProduit], [ImgProduit], [PrixProduit], [DescriptionProduit], [Marque_IdMarque], [Categorie_IdCategorie], [Commande_Id], [Fournisseurs_Idfournisseur]) VALUES (3, N'Gel Douche', N'img', CAST(16.00 AS Decimal(18, 2)), N'chimique', 2, 3, NULL, NULL)
INSERT INTO [dbo].[Produits] ([IdProduit], [NomProduit], [ImgProduit], [PrixProduit], [DescriptionProduit], [Marque_IdMarque], [Categorie_IdCategorie], [Commande_Id], [Fournisseurs_Idfournisseur]) VALUES (4, N'Deodorant', N'img', CAST(5.00 AS Decimal(18, 2)), N'chimique', 4, 2, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Produits] OFF
