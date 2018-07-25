﻿CREATE TABLE [dbo].[UNITE] (
    [CODE_UNITE]   DECIMAL (18)  IDENTITY (1, 1) NOT NULL,
    [LIB_UNITE]    NVARCHAR (15) NULL,
    [ABREGE_UNITE] NVARCHAR (15) NULL,
    CONSTRAINT [PK_UNITE] PRIMARY KEY CLUSTERED ([CODE_UNITE] ASC)
);

