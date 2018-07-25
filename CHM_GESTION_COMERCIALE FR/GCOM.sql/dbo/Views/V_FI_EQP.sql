CREATE VIEW [dbo].[V_FI_EQP]
AS
SELECT     dbo.FICHE_INTERVENTION.NUM_FI, dbo.FICHE_INTERVENTION.DATE_FI, dbo.FICHE_INTERVENTION.CODE_VEHICULE, dbo.FICHE_INTERVENTION.KILOMETRAGE, 
                      dbo.FICHE_INTERVENTION.CODE_B_LIV, dbo.FICHE_INTERVENTION.USER_CR, dbo.FICHE_INTERVENTION.DATE_MODIF, dbo.FICHE_INTERVENTION.USER_MODIF, 
                      dbo.FICHE_INTERVENTION.CLOTURE, dbo.FICHE_INTERVENTION.DATE_CLOTURE, dbo.FICHE_INTERVENTION.USER_CLOTURE, 
                      dbo.FICHE_INTERVENTION.TYPE_PIECE_REG, dbo.FICHE_INTERVENTION.CODE_MAG, dbo.CLIENT.REF_CLIENT, dbo.CLIENT.RS_CLIENT, dbo.CLIENT.TEL_CLIENT, 
                      dbo.EQUIPEMENT.LIBELLE_EQP, dbo.EQUIPEMENT.NUM_SERIE, dbo.EQUIPEMENT.DATE_FAB_EQP, dbo.EQUIPEMENT.DATE_MISE_SERVICE_EQP, 
                      dbo.EQUIPEMENT.FABRIQUANT, dbo.EQUIPEMENT.CODE_CLIENT
FROM         dbo.EQUIPEMENT INNER JOIN
                      dbo.CLIENT ON dbo.EQUIPEMENT.CODE_CLIENT = dbo.CLIENT.CODE_CLIENT INNER JOIN
                      dbo.FICHE_INTERVENTION ON dbo.EQUIPEMENT.CODE_EQP = dbo.FICHE_INTERVENTION.CODE_VEHICULE
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FI_EQP';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FI_EQP';


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
         Begin Table = "FICHE_INTERVENTION"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CLIENT"
            Begin Extent = 
               Top = 6
               Left = 496
               Bottom = 114
               Right = 693
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "EQUIPEMENT"
            Begin Extent = 
               Top = 11
               Left = 248
               Bottom = 119
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
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
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_FI_EQP';

