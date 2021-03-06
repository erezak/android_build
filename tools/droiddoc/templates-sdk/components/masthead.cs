<?cs def:custom_masthead() ?>
    <!-- Header -->
    <div id="header">
        <div class="wrap" id="header-wrap">
          <div class="col-3 logo">
          <a href="<?cs var:toroot ?>index.html">
            <img src="<?cs var:toroot ?>assets/images/dac_logo.png" width="123" height="25" alt="Android Developers" />
          </a>
          <div class="btn-quicknav" id="btn-quicknav">
          	<a href="#" class="arrow-inactive">Quicknav</a>
			<a href="#" class="arrow-active">Quicknav</a>
          </div>
          </div>
            <ul class="nav-x col-9">
                <li class="design"><a href="<?cs var:toroot ?>design/index.html" <?cs
                  if:design ?>class="selected"<?cs /if ?> >Design</a></li>
                <li class="develop"><a href="<?cs var:toroot ?>develop/index.html" <?cs
                  if:training || guide || reference || tools || develop ?>class="selected"<?cs /if ?> >Develop</a></li>
                <li class="distribute last"><a href="<?cs var:toroot ?>distribute/index.html" <?cs
                  if:distribute ?>class="selected"<?cs /if ?> >Distribute</a></li>
            </ul>
            
            <!-- New Search -->
            <div class="menu-container">
            <div class="moremenu">
    <div id="more-btn"></div>
  </div>
  <div class="morehover" id="moremenu">
    <div class="top"></div>
    <div class="mid">
      <div class="header">Links</div>
      <ul>
        <li><a href="https://play.google.com/apps/publish/">Google Play Developer Console</a></li>
        <li><a href="http://android-developers.blogspot.com/">Android Developers Blog</a></li>
        <li><a href="<?cs var:toroot ?>about/index.html">About Android</a></li>
      </ul>
      <div class="header">Android Sites</div>
      <ul>
        <li><a href="http://www.android.com">Android.com</a></li>
        <li class="active"><a>Android Developers</a></li>
        <li><a href="http://source.android.com">Android Open Source Project</a></li>
      </ul>
      <!-- <div class="header">Support</div>
      <ul>
        <li><a href="<?cs var:toroot ?>support.html">Developer Support</a></li>
      </ul> -->
      <div class="header">Languages</div>
        <div id="language" class="locales">
          <select name="language" onChange="changeLangPref(this.value, true)">
              <option value="en">English</option>
              <option value="es">Español</option>
              <option value="ja">日本語</option>
              <option value="ko">한국어</option>
              <option value="ru">Русский</option>
              <option value="zh-CN">中文 (中国)
      </option>
          </select>	
        </div>
      <script type="text/javascript">
        <!--  
        loadLangPref();  
          //-->
      </script>
      <br class="clearfix" />
    </div>
    <div class="bottom"></div>
  </div>
  <div class="search" id="search-container">
    <div class="search-inner">
      <div id="search-btn"></div>
      <div class="left"></div>
      <form onsubmit="return submit_search()">
        <input id="search_autocomplete" type="text" value="" autocomplete="off" name="q"
onfocus="search_focus_changed(this, true)" onblur="search_focus_changed(this, false)"
onkeydown="return search_changed(event, true, '<?cs var:toroot ?>')" 
onkeyup="return search_changed(event, false, '<?cs var:toroot ?>')" />
      </form>
      <div class="right"></div>
        <a class="close hide">close</a>
        <div class="left"></div>
        <div class="right"></div>
    </div>
  </div>
  <div id="search_filtered_wrapper">
    <div id="search_filtered_div" class="no-display">
        <ul id="search_filtered">
        </ul>
    </div>
  </div>
  
  </div>
  <!-- /New Search>
          
          
          <!-- Expanded quicknav -->
           <div id="quicknav" class="col-9">
                <ul>
                    <li class="design">
                      <ul>
                        <li><a href="<?cs var:toroot ?>design/style/index.html">Style</a></li>
                        <li><a href="<?cs var:toroot ?>design/patterns/index.html">Patterns</a></li>
                        <li><a href="<?cs var:toroot ?>design/building-blocks/index.html">Building Blocks</a></li>
                        <li><a href="<?cs var:toroot ?>design/downloads/index.html">Downloads</a></li>
                      </ul>
                    </li>
                    <li class="develop">
                      <ul>
                        <li><a href="<?cs var:toroot ?>training/index.html">Android Training</a></li>
                        <li><a href="<?cs var:toroot ?>guide/components/index.html">API Guides</a></li>
                        <li><a href="<?cs var:toroot ?>reference/packages.html">Reference</a></li>
                        <li><a href="<?cs var:toroot ?>tools/index.html">Tools</a>
                          <ul><li><a href="<?cs var:toroot ?>sdk/index.html">Get the
SDK</a></li></ul>
                        </li>
                      </ul>
                    </li>
                    <li class="distribute last">
                      <ul>
                        <li><a href="<?cs var:toroot ?>distribute/index.html">Google Play</a></li>
                        <li><a href="<?cs var:toroot ?>distribute/googleplay/publish/index.html">Publishing</a></li>
                        <li><a href="<?cs var:toroot ?>distribute/googleplay/promote/index.html">Promoting</a></li>
                        <!--<li><a href="<?cs var:toroot ?>distribute/googleplay/strategies/index.html">Strategies</a></li> -->
                        <li><a href="<?cs var:toroot ?>distribute/open.html">Open
Distribution</a></li> 
                      </ul>
                    </li>
                </ul>
          </div>
          <!-- /Expanded quicknav -->
        </div>
    </div>
    <!-- /Header -->
    
    
  <div id="searchResults" class="wrap" style="display:none;">
          <h2 id="searchTitle">Results</h2>
          <div id="leftSearchControl" class="search-control">Loading...</div>
  </div>
    
    
    
<?cs if:training || guide || reference || tools || develop ?>
    <!-- Secondary x-nav -->
    <div id="nav-x">
        <div class="wrap">
            <ul class="nav-x col-9 develop" style="width:75%">
                <li><a href="<?cs var:toroot ?>training/index.html" <?cs
                  if:training ?>class="selected"<?cs /if ?> >Android Training</a></li>
                  <li><a href="<?cs var:toroot ?>guide/components/index.html" <?cs
                  if:guide ?>class="selected"<?cs /if ?> >API Guides</a></li>
                <li><a href="<?cs var:toroot ?>reference/packages.html" <?cs
                  if:reference ?>class="selected"<?cs /if ?> >Reference</a></li>
                <li><a href="<?cs var:toroot ?>tools/index.html" <?cs
                  if:tools ?>class="selected"<?cs /if ?> >Tools</a></li>
            </ul>
          <!--  <a class="button-secondary download-sdk">Download the SDK</a> -->
        </div>
        
    </div>
    <!-- /Sendondary x-nav -->
<?cs /if ?>
  <?cs 
/def ?>
