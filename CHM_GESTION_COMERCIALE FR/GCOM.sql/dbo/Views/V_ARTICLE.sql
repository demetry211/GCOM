CREATE VIEW dbo.V_ARTICLE
AS
SELECT        dbo.ARTICLE.CODE_ARTICLE, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.CODE_MARQUE, dbo.ARTICLE.DESCRIPTION_ARTICLE, dbo.ARTICLE.CODE_BARRE_ARTICLE, 
                         dbo.ARTICLE.QTE_ARTICLE, dbo.ARTICLE.CODE_UNITE, dbo.ARTICLE.QTE_MIN_ARTICLE, dbo.ARTICLE.PHOTO_ARTICLE, dbo.ARTICLE.PRIX_HT_A_ARTICLE, dbo.ARTICLE.TAUX_MAJORATION, dbo.ARTICLE.CODE_TVA, 
                         dbo.ARTICLE.ETAT_ARTICLE, dbo.ARTICLE.CODE_FAMILLE, dbo.ARTICLE.CODE_CATEG, dbo.ARTICLE.CODE_MAG, dbo.ARTICLE.CODE_FOURNISSEUR, dbo.ARTICLE.PRIX_HT_V_ARTICLE, dbo.FAMILLE.REF_FAMILLE, 
                         dbo.FAMILLE.DESIGNATION_FAMILLE, dbo.FAMILLE.DESCRIPTION_FAMILLE, dbo.CATEGORIE.LIB_CATEG, dbo.CATEGORIE.DESCRIPTION_CATEG, dbo.MARQUE.REF_MARQUE, dbo.MARQUE.DESIGNATION_MARQUE, 
                         dbo.MARQUE.DESCRIPTION_MARQUE, dbo.UNITE.LIB_UNITE, dbo.FOURNISSEUR.REF_FOURNISSEUR, dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.FOURNISSEUR.ADRESSE_FOURNISSEUR, 
                         dbo.FOURNISSEUR.TEL_FOURNISSEUR, TVA_1.TAUX_TVA, dbo.MAGAZIN.NOM_MAG, dbo.MAGAZIN.ADRESSE_MAG, dbo.MAGAZIN.TEL_MAG, dbo.ARTICLE.REF_FRN, dbo.ARTICLE.STOCKABLE, dbo.ARTICLE.TVA_ACHAT, 
                         dbo.TVA.TAUX_TVA AS TAUX_TVA_ACHAT
FROM            dbo.ARTICLE LEFT OUTER JOIN
                         dbo.FAMILLE ON dbo.ARTICLE.CODE_FAMILLE = dbo.FAMILLE.CODE_FAMILLE INNER JOIN
                         dbo.CATEGORIE ON dbo.ARTICLE.CODE_CATEG = dbo.CATEGORIE.CODE_CATEG LEFT OUTER JOIN
                         dbo.FOURNISSEUR ON dbo.ARTICLE.CODE_FOURNISSEUR = dbo.FOURNISSEUR.CODE_FOURNISSEUR LEFT OUTER JOIN
                         dbo.MARQUE ON dbo.ARTICLE.CODE_MARQUE = dbo.MARQUE.CODE_MARQUE LEFT OUTER JOIN
                         dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE INNER JOIN
                         dbo.MAGAZIN ON dbo.ARTICLE.CODE_MAG = dbo.MAGAZIN.CODE_MAG INNER JOIN
                         dbo.TVA ON dbo.ARTICLE.TVA_ACHAT = dbo.TVA.CODE_TVA LEFT OUTER JOIN
                         dbo.TVA AS TVA_1 ON dbo.ARTICLE.CODE_TVA = TVA_1.CODE_TVA
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'280
            TopColumn = 2
         End
         Begin Table = "TVA"
            Begin Extent = 
               Top = 101
               Left = 934
               Bottom = 197
               Right = 1104
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TVA_1"
            Begin Extent = 
               Top = 210
               Left = 503
               Bottom = 288
               Right = 694
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 46
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[64] 4[5] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -347
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ARTICLE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 271
            End
            DisplayFlags = 280
            TopColumn = 24
         End
         Begin Table = "FAMILLE"
            Begin Extent = 
               Top = 6
               Left = 309
               Bottom = 114
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CATEGORIE"
            Begin Extent = 
               Top = 6
               Left = 543
               Bottom = 99
               Right = 734
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FOURNISSEUR"
            Begin Extent = 
               Top = 102
               Left = 543
               Bottom = 210
               Right = 753
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "MARQUE"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 222
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UNITE"
            Begin Extent = 
               Top = 114
               Left = 274
               Bottom = 192
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MAGAZIN"
            Begin Extent = 
               Top = 192
               Left = 274
               Bottom = 300
               Right = 465
            End
            DisplayFlags = ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_ARTICLE';

