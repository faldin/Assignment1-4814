<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
<xsl:output method="html" indent="yes"/>
  
    <xsl:template match="/">
      <style type="text/css">
        .semesterFont
        {
        font-family:sans-serif;
        font-size:9pt;
        style="height:5px";
        color: red;
        }
        .semesterFontPrevious
        {
        font-family:sans-serif;
        font-size:1pt;
        style="height:5px";
        color: red;
        }
        .table1, .table1 TD, .table1 TH
        {
        font-family:sans-serif;
        font-size:9pt;
        style="height:5px";
        color:black;
        background-color:"#F2F5A9";>
        }
        .table2, .table2 TD, .table2 TH
        {
        font-family:sans-serif;
        font-size:7pt;
        style="height:5px";
        color:black;
        background-color:"#F2F5A9";>
        }
      </style>

      <html>
        <body>
          <table border ="1" cellspacing ="0" cellpadding="3" style ="width:90%">
            <tr>
              <th>Name</th>
              <th>Rating</th>
              <th>Average Price Per Night</th>
            
            </tr>
            
              <xsl:apply-templates select="../../hoorayforhtml.html">
            
            </xsl:apply-templates>
              
          
          </table>
      
      </body>
  
  </html>
        
    </xsl:template>
<xsl:template match="Hotel">
            
              <tr>
                <td>
                  <xsl:value-of select="Name"/>
                </td>
                <td>
              <xsl:apply-templates select="Rating"/>
               </td>
                
                <td>
              <xsl:apply-templates select="RoomType"/>
              </td>
            </tr>

</xsl:template>
  
  <xsl:template match ="Rating">
    
            <xsl:choose>
            <xsl:when test = "Rating = 1">
            <img src ="../../images/image1.jpg"/>
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 1.5" >
            <img src = "../../images/image15.jpg" />
            </xsl:when>
            </xsl:choose>
              
            <xsl:choose>
            <xsl:when test = "Rating = 2" >
            <img src = "../../images/image2.jpg" />
             </xsl:when>
             </xsl:choose>
            <xsl:choose>
             <xsl:when test = "Rating = 2.5" >
            <img src = "../../images/image25.jpg" />
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 3" >
            <img src = "../../images/image3.jpg" />
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 3.5" >
            <img src = "../../images/image35.jpg" />
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 4" >
            <img src = "../../images/image4.jpg" />
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 4.5" >
            <img src = "../../images/image45.jpg" />
            </xsl:when>
            </xsl:choose>
            <xsl:choose>
            <xsl:when test = "Rating = 5" >
             <img src = "../../images/image5.jpg" />
            </xsl:when>
            </xsl:choose>
  
  
  
    </xsl:template>
<xsl:template match ="RoomType">
  
              <td>
                <xsl:value-of select="Name"/>
              </td>
            <td>
                <xsl:value-of select="DailyRate"/>
              </td>
            <td>
                <xsl:value-of select="Capacity"/>
              </td>
              

</xsl:template>
</xsl:stylesheet>
