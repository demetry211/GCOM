CREATE VIEW [dbo].[VLG_BR_FR_SANS_FACT]
AS
SELECT DISTINCT 
                      dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP, dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR, dbo.LG_BR_FR.CODE_ARTICLE, dbo.ARTICLE.REF_ARTICLE, 
                      dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.DESCRIPTION_ARTICLE, dbo.LG_BR_FR.QTE_LG_BR_FR -
                          (SELECT     ISNULL(SUM(QTE), 0) AS Expr1
                            FROM          dbo.LG_FACT_FR AS LG_FACT_FR_1
                            WHERE      (CODE_BR_FR = dbo.LG_BR_FR.CODE_BRECEP) AND (CODE_ARTICLE = dbo.LG_BR_FR.CODE_ARTICLE)) AS QTE, dbo.LG_BR_FR.UNITE, 
                      dbo.LG_BR_FR.PRIX_ART_BR_FR, dbo.LG_BR_FR.TVA, dbo.LG_BR_FR.REMISE, dbo.LG_BR_FR.FODEC, dbo.LG_BR_FR.CODE_CMD_FR, 
                      dbo.LG_BR_FR.CODE_FACT_FR
FROM         dbo.BON_RECEP_FOURNISSEUR INNER JOIN
                      dbo.LG_BR_FR ON dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP = dbo.LG_BR_FR.CODE_BRECEP INNER JOIN
                      dbo.ARTICLE ON dbo.LG_BR_FR.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE
WHERE     ((SELECT     ISNULL(SUM(QTE), 0) AS Expr1
                         FROM         dbo.LG_FACT_FR AS LG_FACT_FR_1
                         WHERE     (CODE_BR_FR = dbo.LG_BR_FR.CODE_BRECEP) AND (CODE_ARTICLE = dbo.LG_BR_FR.CODE_ARTICLE)) < dbo.LG_BR_FR.QTE_LG_BR_FR)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VLG_BR_FR_SANS_FACT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "BON_RECEP_FOURNISSEUR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LG_BR_FR"
            Begin Extent = 
               Top = 2
               Left = 290
               Bottom = 131
               Right = 514
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "ARTICLE"
            Begin Extent = 
               Top = 6
               Left = 552
               Bottom = 114
               Right = 785
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VLG_BR_FR_SANS_FACT';

