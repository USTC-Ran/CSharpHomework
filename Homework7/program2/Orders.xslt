﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="/ArrayOfOrder">
    <html>
      <head>
        OrderList
        <title>OrderList</title>
      </head>
      <body>
        <table border="1">
          <tr  bgcolor="#9acd32">
            <th>订单号</th>
            <th>订购时间</th>
            <th>客户名称</th>
            <th>客户电话</th>
            <th>商品名称</th>
            <th>商品单价</th>
            <th>商品数量</th>
            <th>订单总价（单位：￥）</th>
          </tr>

          <xsl:for-each select="Order">
            <tr>
              <td>
                <xsl:value-of select="OrderNumber" />
              </td>
              <td>
                <xsl:value-of select="OrderTime" />
              </td>
              <td>
                <xsl:value-of select="Client" />
              </td>
              <td>
                <xsl:value-of select="ClientPhone" />
              </td>
              <xsl:for-each select="OrderDetails">
                <xsl:for-each select="OrderDetails">
                  <td>
                    <xsl:value-of select="GoodsName" />
                  </td>
                  <td>
                    <xsl:value-of select="GoodsPrice" />
                  </td>
                  <td>
                    <xsl:value-of select="GoodsCounts" />
                  </td>
                  <td>
                    <xsl:value-of select="TotalPrice" />
                  </td>
                </xsl:for-each>
              </xsl:for-each> 
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>