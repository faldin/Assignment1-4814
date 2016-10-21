<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <head>
        <STYLE>
          H3 { font-family: Arial,Univers,sans-serif;
          font-size: 12pt;
          text-align: center; }
          H4 { font-family: Arial,Univers,sans-serif;
          font-size: 12pt;
          font-weight: normal;
          text-align: left;
          color: #1a4785;}
          P  { font-family: Arial,Univers,sans-serif;
          font-size: 10pt;
          text-align: center;
          color:#1a4785;}
          TABLE.M { border-color: #1a4785;
          background-color: #eeeeee;
          }
          TR.C { background-color: #beeffd;}

        </STYLE>
      </head>
      <body>
        <h1>Hotels</h1>
        <table class="M" border="1" cellspacing="0" cellpadding="2" width="98%">
          <tr class="C">
            <td>
              <H3>Name</H3>
            </td>
            <td>
              <H3>Rating</H3>
            </td>
            <td>
              <H3>Average Price Per Night</H3>
            </td>
          </tr>
          <xsl:for-each select="ArrayOfHotelListItem/HotelListItem">
            <xsl:sort select="rating" order="descending"/>
            <tr>
              <td>
                <H4>
                  <xsl:value-of select="name"/>
                </H4>
              </td>
              <td>
                <xsl:choose>
                  <xsl:when test="rating = 1.0">
                    <img src="image1.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 1.5">
                    <img src="image15.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 2.0">
                    <img src="image2.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 2.5">
                    <img src="image25.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="image3.png">
                    <img src="image3.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 3.5">
                    <img src="image35.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 4.0">
                    <img src="image4.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 4.5">
                    <img src="image45.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                  <xsl:when test="rating = 5.0">
                    <img src="image5.png" align="left" style="width:150px;height:30px;"></img>
                  </xsl:when>
                </xsl:choose>
              </td>
              <td>
                <table border="1" cellspacing="0" cellpadding="0" width="100%">
                  <tr>
                    <xsl:for-each select="RoomTypes/Room">
                      <td width="25%">
                        <p>
                          <xsl:value-of select="type"/> = $<xsl:value-of select="dailyRate"/>
                        </p>
                      </td>

                    </xsl:for-each>
                  </tr>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>

      </body>

    </html>
  </xsl:template>
</xsl:stylesheet>
