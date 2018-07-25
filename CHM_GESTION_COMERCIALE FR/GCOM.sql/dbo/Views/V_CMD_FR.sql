CREATE VIEW [dbo].[V_CMD_FR]
AS
SELECT     dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, dbo.COMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.CODE_USER, dbo.COMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR, dbo.COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR, 
                      dbo.FOURNISSEUR.REF_FOURNISSEUR, dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.FOURNISSEUR.ADRESSE_FOURNISSEUR, 
                      dbo.FOURNISSEUR.TEL_FOURNISSEUR, dbo.FOURNISSEUR.FAX_FOURNISSEUR, dbo.FOURNISSEUR.CODE_TVA_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.ANNEE_CMDFR, dbo.COMMANDE_FOURNISSEUR.MOIS_CMDFR, dbo.COMMANDE_FOURNISSEUR.CODE_MAG, 
                      dbo.MAGAZIN.NOM_MAG, dbo.MAGAZIN.ADRESSE_MAG, dbo.MAGAZIN.TEL_MAG, dbo.COMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON, 
                      dbo.COMMANDE_FOURNISSEUR.CONTACT, dbo.COMMANDE_FOURNISSEUR.TEL_CONTACT, dbo.COMMANDE_FOURNISSEUR.REMARQUE, 
                      dbo.COMMANDE_FOURNISSEUR.VALIDE, dbo.COMMANDE_FOURNISSEUR.USER_VALIDATION, dbo.COMMANDE_FOURNISSEUR.DATE_VALIDATION, 
                      UTILISATEUR_1.PRENOM_USER + ' ' + UTILISATEUR_1.NOM_USER AS UTILISATEUR_VALIDATION, SUM(dbo.LG_CMD_FR.QTE) AS NBR_ARTICLE,
                          (SELECT     ISNULL(SUM(QTE_LG_BR_FR), 0) AS Expr1
                            FROM          dbo.LG_BR_FR
                            WHERE      (CODE_CMD_FR = dbo.LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR)) AS NBR_ARTICLE_LIVRES
FROM         dbo.COMMANDE_FOURNISSEUR INNER JOIN
                      dbo.FOURNISSEUR ON dbo.COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR = dbo.FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN
                      dbo.UTILISATEUR ON dbo.COMMANDE_FOURNISSEUR.CODE_USER = dbo.UTILISATEUR.CODE_USER INNER JOIN
                      dbo.MAGAZIN ON dbo.COMMANDE_FOURNISSEUR.CODE_MAG = dbo.MAGAZIN.CODE_MAG LEFT OUTER JOIN
                      dbo.LG_CMD_FR ON dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR = dbo.LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR LEFT OUTER JOIN
                      dbo.UTILISATEUR AS UTILISATEUR_1 ON dbo.COMMANDE_FOURNISSEUR.USER_VALIDATION = UTILISATEUR_1.CODE_USER
GROUP BY dbo.COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, dbo.COMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.CODE_USER, dbo.COMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR, dbo.COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR, 
                      dbo.FOURNISSEUR.REF_FOURNISSEUR, dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.FOURNISSEUR.ADRESSE_FOURNISSEUR, 
                      dbo.FOURNISSEUR.TEL_FOURNISSEUR, dbo.FOURNISSEUR.FAX_FOURNISSEUR, dbo.FOURNISSEUR.CODE_TVA_FOURNISSEUR, 
                      dbo.COMMANDE_FOURNISSEUR.ANNEE_CMDFR, dbo.COMMANDE_FOURNISSEUR.MOIS_CMDFR, dbo.COMMANDE_FOURNISSEUR.CODE_MAG, 
                      dbo.MAGAZIN.NOM_MAG, dbo.MAGAZIN.ADRESSE_MAG, dbo.MAGAZIN.TEL_MAG, dbo.COMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON, 
                      dbo.COMMANDE_FOURNISSEUR.CONTACT, dbo.COMMANDE_FOURNISSEUR.TEL_CONTACT, dbo.COMMANDE_FOURNISSEUR.REMARQUE, 
                      dbo.COMMANDE_FOURNISSEUR.VALIDE, dbo.COMMANDE_FOURNISSEUR.USER_VALIDATION, dbo.COMMANDE_FOURNISSEUR.DATE_VALIDATION, 
                      UTILISATEUR_1.PRENOM_USER, UTILISATEUR_1.NOM_USER, dbo.LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_CMD_FR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'00
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
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_CMD_FR';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[4] 2[30] 3) )"
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
         Top = -288
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COMMANDE_FOURNISSEUR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 352
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "FOURNISSEUR"
            Begin Extent = 
               Top = 171
               Left = 696
               Bottom = 279
               Right = 906
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR"
            Begin Extent = 
               Top = 216
               Left = 1
               Bottom = 324
               Right = 200
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "MAGAZIN"
            Begin Extent = 
               Top = 147
               Left = 443
               Bottom = 255
               Right = 634
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UTILISATEUR_1"
            Begin Extent = 
               Top = 6
               Left = 638
               Bottom = 136
               Right = 855
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LG_CMD_FR"
            Begin Extent = 
               Top = 433
               Left = 303
               Bottom = 546
               Right = 610
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
      Begin ColumnWidths = 29
         Width = 284
         Width = 15', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_CMD_FR';

