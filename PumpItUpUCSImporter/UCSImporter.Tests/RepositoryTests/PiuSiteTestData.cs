namespace UCSImporter.Tests.RepositoryTests;

public static class PiuSiteTestData
{
    public static readonly string UcsPageData = @"
<!doctype html>
<html lang=""ko"">
<head>
<meta charset=""utf-8"">
<!--<meta name='viewport' content='user-scalable=no, width=device-width'/> // 디바이스에서 확대 불가 -->
<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no, width=device-width, target-density-dpi=device-dpi"">
<link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic' rel='stylesheet' type='text/css'> 
<link rel=""shortcut icon"" href=""/piu.ucs/ucs.img/favicon_arrow.ico"">
<meta http-equiv=""imagetoolbar"" content=""no"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=10,chrome=1"">
<title>UCS Share | PUMP IT UP!</title>
<link rel=""stylesheet"" href=""https://www.piugame.com/css/default.css"">
<link rel=""stylesheet"" href=""https://www.piugame.com/skin/outlogin/ucs_basic/style.css"">
<link rel=""stylesheet"" href=""https://www.piugame.com/skin/board/ucs_share/list.style.css"">
<!--[if lte IE 8]>
<script src=""https://www.piugame.com/js/html5.js""></script>
<![endif]-->
<script>
// 자바스크립트에서 사용하는 전역변수 선언
var g5_url       = ""https://www.piugame.com"";
var g5_bbs_url   = ""https://www.piugame.com/bbs"";
var g5_is_member = """";
var g5_is_admin  = """";
var g5_is_mobile = """";
var g5_bo_table  = ""ucs"";
var g5_sca       = """";
var g5_editor    = """";
var g5_cookie_domain = "".piugame.com"";
//=== LAN
var MENU_LANG_STR = ""en"";
</script>
<script src=""https://www.piugame.com/js/jquery-1.8.3.min.js""></script>
<script src=""https://www.piugame.com/js/jquery.menu.js""></script>
<script src=""https://www.piugame.com/js/common.js""></script>
<script src=""https://www.piugame.com/js/wrest.js""></script>
<script src='/piu.ucs/ucs.js/ucs.common.js'></script><!-- 2018-03-29-->
<script src='/piu.ucs/ucs.js/tabbedContent.js'></script><!-- tap  2015-06-01-->
<script src='/piu.ucs/ucs.js/ucs.marquee.js'></script><!-- scroll -->
<script type=""text/javascript"" src=""/piu.js/piu_tab.js""></script><!-- tap2 -->

<!-- 2014-11-21 언어선택 서포트 -->
<script type=""text/javascript"" src=""/piu.js/piu.default.js""></script>
<!-- 2014-11-21 언어선택 서포트 -->
<!--<script src=""https://www.piugame.com/js/piu.default.js""></script>-->

<!-- UCS 전용 스크립트 --> 
<script src=""/piu.ucs/ucs.js/ucs.url.js""></script>
<!-- UCS 전용 스크립트 끝 --> 
<!-- UCS 전용 CSS --> 
<link type=""text/css"" href=""/piu.ucs/ucs.css/piu.reset.css"" rel=""stylesheet"">
<link type=""text/css"" href=""/piu.ucs/ucs.css/ucs.style.css"" rel=""stylesheet"">
<!-- UCS 전용 CSS 끝 --> 


</head>
<body>
<!--[if IE]><script type=""text/javascript"" src=""/js/excanvas.js""></script><![endif]-->
<div class=""top_menu_bg""></div>
<div class=""ucs_navi_bg""></div>
<div id =""ucs_warp"">
<header>
<!-- 탑 메뉴 시작 -->
	<div class=""topMenubox"">
				<div class=""topMenuArea"">	
				<ul class=""topMenu"">
					<!-- PC 언어변경 -->
					<li class=""topSub language""><a class=""subFont2 f600"" ><i class=""fa fa-caret-down mr10""></i>▽ LANGUAGE</a>
						<ul class=""languageSub"" id=""set_language_top"">
							<li data-language='ko-kr'><span class=""""><img src=""/piu.countryImg/104.png"" width=""20""> KOREAN</span></li> 
							<li data-language='en-us'><span class=""on""><img src=""/piu.countryImg/196.png"" width=""20""> ENGLISH</span></li>
							<li data-language='ja-jp'><span class=""""><img src=""/piu.countryImg/100.png"" width=""20"" > JAPANESE</span></li>
						</ul>
					</li>
					<!-- PC 언어변경 끝 -->
					<li><a href=""/"">PRIME 2</a></li>
										<li><a href=""https://www.piugame.com/bbs/piu.register.php"">Join</a></li>
					<li><a class=""reg_box"" href=""https://www.piugame.com/bbs/piu.login.php""><b>Login</b></a></li>
																			</ul>
			</div>
		</div>
<!-- 메뉴 시작 -->
<nav class=""ucs_navi"">
	<ul>
		<li><a href=""javascript:url('menu_ucs_intro');"">U.C.S ?</a></li>
		<li><a href=""javascript:url('menu_my_upload');"">My activity</a>
				</li>
		<li><a href=""javascript:url('menu_ucs_share');"">U.C.S Sharing</a></li>
				<li><a href=""javascript:url('menu_ucs_contest');"">Contest</a>
			<ul class=""ucs_navi_sub"">
				<li><a href=""javascript:url('menu_ucs_contest');"">Contest list</a></li>
				<li>|</li>
				<li><a href=""javascript:url('menu_contest_evaluation');"">Evaluation standard</a></li>
				
			</ul>
		</li>
		<li><a href=""/bbs/board.php?bo_table=ucs_notice"">Community</a>
			<ul class=""ucs_navi_sub"">
				<li><a href=""/bbs/board.php?bo_table=ucs_notice"">Notice</a></li>
							</ul>
		</li>
		<li><a href=""javascript:url('menu_ucs_upload');"">File upload</a></li>
		<li><a href=""javascript:url('menu_sample_alltunes');"">Sample download</a>
	</ul>
</nav>
<!-- 메뉴 끝 -->
<!-- 로고 시작 -->
<div id=""logo_map"">
<a href=""javascript:url('menu_index');""><img src=""/piu.ucs/ucs.img/ucs_pump_logo.png"" width=""214"" height=""124"" alt=""pump logo"" title=""pump logo""></a><br>
<span class=""ucs_img_text"">OFFICIAL SITE OF USER CUSTOM STEP</span>
<!-- 패밀리 사이트 --> 
<div class=""familySite"">
		<a href=""/piu.prime2/piu.main.php?site_version=PRIME2""><img src=""/piu.prime2/_img/top_prime2_logo.png""> WebPage ></a>
</div>	
<!-- 패밀리 사이트 끝 -->
</div>
<!-- 로고 끝 -->
<!-- 로그인 부분 시작 -->
<div class=""ucs_member_login"">

<!-- 로그인 전 아웃로그인 시작 { -->
<section id=""ol_before"" class=""ol"">
       <span class=""ucs_login"">USER LOGIN</span>
	<form name=""foutlogin"" action=""https://www.piugame.com/bbs/piu.login_check.php"" onsubmit=""return fhead_submit(this);"" method=""post"" autocomplete=""off"">
    <fieldset>
        <input type=""hidden"" name=""url"" value=""https://www.piugame.com/bbs/board.php?bo_table=ucs&sop=and&sst=wr_datetime&sod=desc&sfl=&stx=&page=1"">
        <label for=""ol_id"" id=""ol_idlabel""> Input member email<strong class=""sound_only"">필수</strong></label>
        <input type=""text"" id=""ol_id"" name=""mb_id"" required class=""required"" maxlength=""40"">
        <label for=""ol_pw"" id=""ol_pwlabel""> Password<strong class=""sound_only"">필수</strong></label>
        <input type=""password"" name=""mb_password"" id=""ol_pw"" required class=""required"" maxlength=""50"">
    

<div id=""login_btn"">

<input type=""submit"" class=""ucs_login_btn"" value=""LOGIN"" width=""220"" height=""44"" alt=""login_button"" title=""login_button"" id=""ol_submit"" >

</div>
		
		    </fieldset>
    </form>
</section>

<script>
$omi = $('#ol_id');
$omp = $('#ol_pw');
$omp.css('display','inline-block');
$omi_label = $('#ol_idlabel');
$omi_label.addClass('ol_idlabel');
$omp_label = $('#ol_pwlabel');
$omp_label.addClass('ol_pwlabel');

$(function() {
    $omi.focus(function() {
        $omi_label.css('visibility','hidden');
    });
    $omp.focus(function() {
        $omp_label.css('visibility','hidden');
    });
    $omi.blur(function() {
        $this = $(this);
        if($this.attr('id') == ""ol_id"" && $this.attr('value') == """") $omi_label.css('visibility','visible');
    });
    $omp.blur(function() {
        $this = $(this);
        if($this.attr('id') == ""ol_pw"" && $this.attr('value') == """") $omp_label.css('visibility','visible');
    });

    $(""#auto_login"").click(function(){
        if ($(this).is("":checked"")) {
            if(!confirm(""자동로그인을 사용하시면 다음부터 회원아이디와 비밀번호를 입력하실 필요가 없습니다.\n\n공공장소에서는 개인정보가 유출될 수 있으니 사용을 자제하여 주십시오.\n\n자동로그인을 사용하시겠습니까?""))
                return false;
        }
    });

	// 2014-10-28 전환하기 버튼
	$(""#btn_change_up"").click(function() {
		location.replace(""https://www.piugame.com/bbs/piu.member_change_up1.php"");
	});
});

function fhead_submit(f)
{
    return true;
}
</script>
<!-- } 로그인 전 아웃로그인 끝 -->
</div>
<!-- 로그인 끝 -->

<!-- 페이지 이동 시작-->
<div class=""page_top""><a href=""#""><img src=""/piu.ucs/ucs.img/up_btn.png""></a></div>
<!-- 페이지 이동 끝 -->

</header><!-- // 무대 시작 // 본문 시작 -->
<script type=""text/javascript"" src=""/js/jquery.smartPop.js""></script>
<link rel=""stylesheet"" href=""/css/jquery.smartPop.css"" />

<div class=""content_body clear"">
<!-- 타이틀 시작 -->
<div class=""ucs_title"">
<span class=""ucs_title_text"">U.C.S Sharing</span><ul class=""ucs_title_location"">
<li><a href=""javascript:url('menu_index');"">HOME</a></li>
<li><</li>
<li><a href=""javascript:url('menu_ucs_share');"">U.C.S Sharing</a></li>
</div>
<!-- 타이틀 끝 -->
<!-- 내용 시작! -->
<div class=""content_start"">
<div class=""select_info"">You can share your U.C.S charts with other users. Evaluate other's charts after preview.</div>
<!-- 게시물 정렬 메뉴 시작 -->
	<!-- 게시물 정렬 메뉴 끝 -->
<!-- @@@UCS EVENT COMBO START -->
<div class=""ucs_contest_combo""><span class=""contest_sub"">You can only check the steps of the selected contest.</span></div>
<!-- @@@UCS EVENT COMBO END -->
<!-- 게시판 목록 시작 { -->
<div class=""share_mode_sort"" style=""width:100%"">

    <!-- 게시판 카테고리 시작 { -->
        <nav class=""share_mode_cate_list"">
        <ul class=""share_mode_cate_ul"">
            <li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs"" id=""bo_cate_on"">Total</a></li><li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;sca=S"">Single</a></li><li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;sca=SP"">SinglePerformance</a></li><li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;sca=D"">Double</a></li><li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;sca=DP"">DoublePerformance</a></li><li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;sca=CO"">CO-OP</a></li>        </ul>
    </nav>
        <!-- } 게시판 카테고리 끝 -->

<!-- 게시판 보기 방식 선택 및 페이지 정보 시작 -->
<div class=""share_board_info"">
	<ul class=""board_view"">
		<li><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&bo_type=list"" title=""리스트형""><img src=""/skin/board/ucs_share/img/board_view_list.gif""></a></li>
			</ul>
	 <div class=""share_board_info_text"">
				<span>Total 10,599 cases </span>
				1 Page	</div>
</div>
<!-- 게시판 검색 시작 { -->
<fieldset class=""share_board_sch_up"">
    <legend>게시물 검색</legend>

    <form name=""fsearch"" method=""get"">
	<input type=""hidden"" name=""ucs_event_no"" value="""">
    <input type=""hidden"" name=""bo_table"" value=""ucs"">
    <input type=""hidden"" name=""sca"" value="""">
    <input type=""hidden"" name=""sop"" value=""and"">
    <label for=""sfl"" class=""sound_only"">Searching Target</label>
    <select name=""sfl"" id=""sfl"">
        <option value=""wr_name,1"">Step maker</option>
		<option value=""ucs_step_level,1"">Level</option> <!-- 숫자만 입력이 가능해야합니다 -->
		<option value=""wr_content,1"">content</option> <!-- 숫자만 입력이 가능해야합니다 -->
        <option value=""ucs_song_no,1"">Song title </option>
    </select>
    <label for=""stx"" class=""sound_only"">Search word<strong class=""sound_only"">Required</strong></label>
    <input type=""text"" name=""stx"" value="""" required id=""stx"" class=""frm_input required"" size=""40"" maxlength=""40"">
    <input type=""submit"" value=""Search"" class=""share_board_sch_btn"">
    </form>
</fieldset>
<!-- } 게시판 검색 끝 -->

<!-- 게시판 보기 방식 선택 및 페이지 정보 끝 -->


    <!-- 게시판 버튼 시작 { -->

    <div class=""share_board_btn_list"">
           </div>
    <!-- } 게시판 버튼 끝 -->

    <form name=""fboardlist"" id=""fboardlist"" action=""./board_list_update.php"" onsubmit=""return fboardlist_submit(this);"" method=""post"">
	<input type=""hidden"" name=""ucs_event_no"" value="""">
    <input type=""hidden"" name=""bo_table"" value=""ucs"">
    <input type=""hidden"" name=""sfl"" value="""">
    <input type=""hidden"" name=""stx"" value="""">
    <input type=""hidden"" name=""spt"" value="""">
    <input type=""hidden"" name=""sca"" value="""">
    <input type=""hidden"" name=""page"" value=""1"">
    <input type=""hidden"" name=""sw"" value="""">

    <div class=""share_list"">
        <table>
       <caption>PIU UCS</caption>
        <thead>
        <tr>
            			<th scope=""col"">No.</th>
            <th scope=""col"">Song title / Artist</th>
            <th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=wr_name&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Step maker</a></th>
			<th scope=""col"">Step</th>
			<th scope=""col"" class=""player_th""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=ucs_player&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Player(s)</a></th>
			<th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=ucs_vote_rate&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Grade</a></th>
			<th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=wr_good&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Like</a></th>
            <th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=wr_datetime&amp;sod=asc&amp;sfl=&amp;stx=&amp;page=1"">Upload date</a></th>
            <th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=wr_comment&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Comment</a></th>
			<th scope=""col""><a href=""/bbs/board.php?bo_table=ucs&amp;sop=and&amp;sst=wr_view&amp;sod=desc&amp;sfl=&amp;stx=&amp;page=1"">Download</a></th>
        </tr>
        </thead>
       <tbody>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10599			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/272.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27228&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Final Audition Ep. 2-1</a></span><span class=""share_artist"">YAHPP</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;HAALL</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_double s_lv24""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27228&#SongID=S068#UCS=/data/file/ucs/3731906904_A93XGB5H_CS068#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27228'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27228&#SongID=S068#UCS=/data/file/ucs/3731906904_A93XGB5H_CS068#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27228&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27228&#SongID=S068#UCS=/data/file/ucs/3731906904_A93XGB5H_CS068#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10598			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/37.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27227&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Bee</a></span><span class=""share_artist"">BanYa</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;acacia</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_coop s_lv03""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27227&#SongID=S046#UCS=/data/file/ucs/3717280541_pG7x0yaE_CS046#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27227'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27227&#SongID=S046#UCS=/data/file/ucs/3717280541_pG7x0yaE_CS046#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27227&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27227&#SongID=S046#UCS=/data/file/ucs/3717280541_pG7x0yaE_CS046#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10597			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/583.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27226&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Nyarlathotep</a></span><span class=""share_artist"">Nato</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/100.gif"">&nbsp;&nbsp;LIONRS</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_douper s_lv24""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27226&#SongID=S278#UCS=/data/file/ucs/3020848435_4QSrOR6F_CS278#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27226'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27226&#SongID=S278#UCS=/data/file/ucs/3020848435_4QSrOR6F_CS278#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27226&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27226&#SongID=S278#UCS=/data/file/ucs/3020848435_4QSrOR6F_CS278#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10596			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/390.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27225&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Mad5cience</a></span><span class=""share_artist"">Paul Bazooka</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;GOGENWOO2</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_coop s_lv02""></span><br><img src=""/piu.ucs/ucs.img/chart_coop.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">2</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27225&#SongID=S181#UCS=/data/file/ucs/1888750633_XUKST9uh_CS181_1#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27225'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27225&#SongID=S181#UCS=/data/file/ucs/1888750633_XUKST9uh_CS181_1#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27225&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27225&#SongID=S181#UCS=/data/file/ucs/1888750633_XUKST9uh_CS181_1#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10595			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/598.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27224&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">1949</a></span><span class=""share_artist"">SLAM</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;GOGENWOO2</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_sinper s_lv14""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27224&#SongID=S293#UCS=/data/file/ucs/1888750633_VmQcSt9k_CS293#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27224'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27224&#SongID=S293#UCS=/data/file/ucs/1888750633_VmQcSt9k_CS293#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27224&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27224&#SongID=S293#UCS=/data/file/ucs/1888750633_VmQcSt9k_CS293#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10594			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/390.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27223&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Mad5cience</a></span><span class=""share_artist"">Paul Bazooka</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;GOGENWOO2</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_double s_lv28""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27223&#SongID=S181#UCS=/data/file/ucs/1888750633_Gj0IihT4_CS181_1#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27223'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27223&#SongID=S181#UCS=/data/file/ucs/1888750633_Gj0IihT4_CS181_1#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27223&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27223&#SongID=S181#UCS=/data/file/ucs/1888750633_Gj0IihT4_CS181_1#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10593			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/391.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27222&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Silhouette_Effect</a></span><span class=""share_artist"">Nato</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;Noriter</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv23""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27222&#SongID=S173#UCS=/data/file/ucs/2076737042_niH5C3ph_CS173#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27222'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27222&#SongID=S173#UCS=/data/file/ucs/2076737042_niH5C3ph_CS173#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27222&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27222&#SongID=S173#UCS=/data/file/ucs/2076737042_niH5C3ph_CS173#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10592			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/390.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27219&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Mad5cience</a></span><span class=""share_artist"">Paul Bazooka</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;WISEY_</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_double s_lv17""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-04</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27219&#SongID=S181#UCS=/data/file/ucs/3743930784_6RVrG8j4_CS181#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27219'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27219&#SongID=S181#UCS=/data/file/ucs/3743930784_6RVrG8j4_CS181#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27219&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27219&#SongID=S181#UCS=/data/file/ucs/3743930784_6RVrG8j4_CS181#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10591			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/623.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27218&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">District 1</a></span><span class=""share_artist"">MAX</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;_AKA_</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv18""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27218&#SongID=S319#UCS=/data/file/ucs/1949104914_H8K1Ahfu_CS319#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27218'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27218&#SongID=S319#UCS=/data/file/ucs/1949104914_H8K1Ahfu_CS319#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27218&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27218&#SongID=S319#UCS=/data/file/ucs/1949104914_H8K1Ahfu_CS319#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10590			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/619.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27217&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Radetzky Can Can</a></span><span class=""share_artist"">BanYa</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;_AKA_</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv18""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27217&#SongID=S314#UCS=/data/file/ucs/1949104914_xbultwIo_CS314#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27217'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27217&#SongID=S314#UCS=/data/file/ucs/1949104914_xbultwIo_CS314#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27217&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27217&#SongID=S314#UCS=/data/file/ucs/1949104914_xbultwIo_CS314#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10589			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/190.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27216&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Super Fantasy</a></span><span class=""share_artist"">SHK</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;yjhgogoyoyo</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv17""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27216&#SongID=S186#UCS=/data/file/ucs/990425488_Yqypao5Z_CS186#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27216'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27216&#SongID=S186#UCS=/data/file/ucs/990425488_Yqypao5Z_CS186#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27216&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27216&#SongID=S186#UCS=/data/file/ucs/990425488_Yqypao5Z_CS186#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10588			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/150.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27211&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">FFF</a></span><span class=""share_artist"">Doin</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;Belics</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv15""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27211&#SongID=S148#UCS=/data/file/ucs/32346260_i1RqTWFA_CS148#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27211'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27211&#SongID=S148#UCS=/data/file/ucs/32346260_i1RqTWFA_CS148#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27211&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27211&#SongID=S148#UCS=/data/file/ucs/32346260_i1RqTWFA_CS148#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10587			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/398.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27210&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Violet Perfume</a></span><span class=""share_artist"">SHK</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;SONG_HAON</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_double s_lv21""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27210&#SongID=S187#UCS=/data/file/ucs/3068212364_WLucMpxk_CS187#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27210'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27210&#SongID=S187#UCS=/data/file/ucs/3068212364_WLucMpxk_CS187#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27210&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27210&#SongID=S187#UCS=/data/file/ucs/3068212364_WLucMpxk_CS187#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10586			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/496.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27209&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Super Capriccio</a></span><span class=""share_artist"">SHK</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;SONG_HAON</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_single s_lv20""></span><br><img src=""/piu.ucs/ucs.img/chart_single.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27209&#SongID=S219#UCS=/data/file/ucs/3068212364_XsDY4m03_CS219#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27209'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27209&#SongID=S219#UCS=/data/file/ucs/3068212364_XsDY4m03_CS219#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27209&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27209&#SongID=S219#UCS=/data/file/ucs/3068212364_XsDY4m03_CS219#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
      <tr>
	    			<td class=""share_no""><!-- 게시글 번호 -->
			10585			<br>
            </td>
			<td class=""share_song""><img src=""/piu.songimg/56.png"" width=""64"" height=""48"">
			<span class=""share_song_title""><a href=""https://www.piugame.com/bbs/board.php?bo_table=ucs&amp;wr_id=27208&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=1"">Phantom -Intermezzo-</a></span><span class=""share_artist"">Banya Production</span></td><!-- 곡(이미지+타이틀+아티스트) -->
            <td class=""share_stepmaker""><img src=""/piu.img/country_no_image/104.gif"">&nbsp;&nbsp;nQp1</td> <!--스텝메이커 -->
			<td class=""share_level""><span class=""s_stepball_double s_lv23""></span><br><img src=""/piu.ucs/ucs.img/chart_double.png""></td><!-- 모드 및 레벨 -->
			<td class=""share_player"">1</td><!-- 플레이어(수) -->
			<td class=""share_rating""><img src=""/skin/board/ucs_share/img/rating_star_on.png"">&nbsp;-</td><!-- 평점-->
			<td class=""share_like""><img src=""/skin/board/ucs_share/img/like_heart.png"">&nbsp;0</td><!-- 좋아요 -->
			<td class=""share_upload_date"">22-04-03</td><!-- upload 날짜 -->
            <td class=""share_reply"">0</td><!-- 뷰어버튼 및 횟수 -->
			<td class=""share_download""><a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27208&#SongID=S101#UCS=/data/file/ucs/662272302_x3yvPeLI_CS101#scrollSpeed=3"" class=""btnUCSPlayrPOP share_download1"">▶&nbsp; P-view</a>
						<a rel="""" class=""btnaddslot_ucs btnAddtoUCSSLOT"" data-ucs_id='27208'>▶&nbsp; SLOT</a>
			<a rel=""/piu.ucs/piu.visual/ucsgame.php?wr_id=27208&#SongID=S101#UCS=/data/file/ucs/662272302_x3yvPeLI_CS101#scrollSpeed=3"" class=""btnUCSPlayr share_download1"">▶&nbsp; VIEW</a>
			<a href=""download.php?bo_table=ucs&wr_id=27208&no=0"" class=""share_download2"">▼ Down</a></td><!-- 다운로드 버튼 및 횟수-->
			<!-- 알아서 가리자 -->
<!--			<br>/piu.ucs/piu.visual/ucsgame.php?wr_id=27208&#SongID=S101#UCS=/data/file/ucs/662272302_x3yvPeLI_CS101#scrollSpeed=3-->
			<!-- 알아서 가리자 -->
        </tr>
		</tbody>
        </table>
    </div>

        </form>
</div>


<!-- 페이지 -->
<nav class=""pg_wrap""><span class=""pg""><span class=""sound_only""><!--열린--></span><strong class=""pg_current"">1</strong><span class=""sound_only""><!--페이지-->Page</span>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=2"" class=""pg_page"">2<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=3"" class=""pg_page"">3<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=4"" class=""pg_page"">4<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=5"" class=""pg_page"">5<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=6"" class=""pg_page"">6<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=7"" class=""pg_page"">7<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=8"" class=""pg_page"">8<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=9"" class=""pg_page"">9<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=10"" class=""pg_page"">10<span class=""sound_only""><!--페이지-->Page</span></a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=11"" class=""pg_page pg_next""><!-다음->▷</a>
<a href=""./board.php?bo_table=ucs&amp;sst=wr_datetime&amp;sod=desc&amp;sop=and&amp;page=707"" class=""pg_page pg_end""><!--맨끝-->>></a>
</span></nav>
<!-- 게시판 검색 시작 { -->
<fieldset class=""share_board_sch"">
    <legend>게시물 검색</legend>

    <form name=""fsearch"" method=""get"">
    <input type=""hidden"" name=""bo_table"" value=""ucs"">
    <input type=""hidden"" name=""sca"" value="""">
    <input type=""hidden"" name=""sop"" value=""and"">
    <label for=""sfl"" class=""sound_only"">Searching Target</label>
    <select name=""sfl"" id=""sfl"">
<!--
        <option value=""wr_subject"">곡 제목</option>
-->
        <option value=""wr_name,1"">Step maker</option>
		<option value=""ucs_step_level,1"">Level</option> <!-- 숫자만 입력이 가능해야합니다 -->
		<option value=""wr_content,1"">content</option> <!-- 숫자만 입력이 가능해야합니다 -->
        <option value=""ucs_song_no,1"">Song title </option>

    </select>
    <label for=""stx"" class=""sound_only"">Search word<strong class=""sound_only"">Required</strong></label>
    <input type=""text"" name=""stx"" value="""" required id=""stx"" class=""frm_input required"" size=""40"" maxlength=""40"">
    <input type=""submit"" value=""Search"" class=""share_board_sch_btn"">
    </form>
</fieldset>
<!-- } 게시판 검색 끝 -->

<!-- } 게시판 목록 끝 -->

<script>
	$(document).ready(function() {

		$('.btnUCSPlayr').click(function() {
			var url = $(this).attr('rel');
			$.smartPop.open({title: 'UCS Player alpha v0.0001', width: 820, height: 580, url: url });
		});

		$('.btnUCSPlayrPOP').click(function() {
			var url = $(this).attr('rel');
			myWindow = window.open(url, ""myWindow"", ""width=860, height=620"");   // Opens a new window
		});

		$(""#ucs_event_no"").on('change', function() {
			var event_no = $(this).val().replace(/[^0-9]/g,'');;
			$(""input[name*='ucs_event_no']"" ).val(event_no);
			if (document.forms[0].name == 'fsearch') {
				document.forms[0].submit();
			}
		});

	});
</script>
<br /><!-- 푸..ㅅ... ㅋㅋ -->
<div class=""footer"">
<div class=""footer_logo""><a href=""""><img src =""/piu.ucs/ucs.img/footer_logo.jpg"" width=""155"" height=""28""></a></div>
<p class=""footer_text"">Copyright © 2015 Andamiro Co., LTD. All rights reserved. <br>Use of this website signifies your agreement to the Terms of Use and Online Privacy Policy</p>
</div>
<!-- 푸..ㅅ... ㅋㅋ 끝 -->
</div>
<!-- 내용 끝 -->
</div>
<!-- 끝났습니다 ㅎㅎ -->
<script>
$(window).scroll(function() {
    if ($(this).scrollTop() > 400) {
        $( "".page_top a"" ).fadeIn();
    } else {
        console.log('there');
        $( "".page_top a"" ).fadeOut();
    }
});
</script>


<!-- ie6,7에서 사이드뷰가 게시판 목록에서 아래 사이드뷰에 가려지는 현상 수정 -->
<!--[if lte IE 7]>
<script>
$(function() {
    var $sv_use = $("".sv_use"");
    var count = $sv_use.length;

    $sv_use.each(function() {
        $(this).css(""z-index"", count);
        $(this).css(""position"", ""relative"");
        count = count - 1;
    });
});
</script>
<![endif]-->
</body>
</html>

<!-- 사용스킨 : basic -->
";
}