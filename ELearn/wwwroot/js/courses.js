/* JS Document */

/******************************

[Table of Contents]

1. Vars and Inits
2. Set Header
3. Init Header Search
4. Init Menu


******************************/

	$(document).ready(function()
	{
		$(document).on("click", ".moreCourse", function () {

			let parent = $(".parentElem")

			let skipCount = $(parent).children().length;

			let courseCount = $("#courses").attr("data-count");

			$.ajax({
				url: `Course/ShowMoreOrLess?skip=${skipCount}`,
				type: "Get",
				success: function (res) {
					$(parent).append(res)
					skipCount = $(parent).children().length;
					if (skipCount >= courseCount) {
						$(".moreCourse").addClass("d-none")
						$(".lessCourse").removeClass("d-none")
					}
				}
			})
		})
		$(document).on("click", ".lessCourse", function () {

			let parent = $(".parentElem")

			let skipCount = 0;

			$.ajax({
				url: `Course/ShowMoreOrLess?skip=${skipCount}`,
				type: "Get",
				success: function (res) {
					$(parent).html("")
					$(parent).append(res)

					$(".lessCourse").addClass("d-none")
					$(".moreCourse").removeClass("d-none")

				}
			})
		})







	"use strict";

	/* 

	1. Vars and Inits

	*/

	var menu = $('.menu');
	var menuActive = false;
	var header = $('.header');
	var burger = $('.hamburger');

	setHeader();

	$(window).on('resize', function()
	{
		setHeader();
	});

	$(document).on('scroll', function()
	{
		setHeader();
	});

	initHeaderSearch();
	initMenu();

	/* 

	2. Set Header

	*/

	function setHeader()
	{
		if($(window).scrollTop() > 100)
		{
			header.addClass('scrolled');
		}
		else
		{
			header.removeClass('scrolled');
		}
	}

	/* 

	3. Init Header Search

	*/

	function initHeaderSearch()
	{
		if($('.search_button').length)
		{
			$('.search_button').on('click', function()
			{
				if($('.header_search_container').length)
				{
					$('.header_search_container').toggleClass('active');
				}
			});
		}
	}

	/* 

	4. Init Menu

	*/

	function initMenu()
	{
		if($('.menu').length)
		{
			var menu = $('.menu');
			if($('.hamburger').length)
			{
				burger.on('click', function()
				{
					if(menuActive)
					{
						closeMenu();
					}
					else
					{
						openMenu();

						$(document).one('click', function cls(e)
						{
							if($(e.target).hasClass('menu_mm'))
							{
								$(document).one('click', cls);
							}
							else
							{
								closeMenu();
							}
						});
					}
				});
			}
		}
	}

	function openMenu()
	{
		menu.addClass('active');
		menuActive = true;
	}

	function closeMenu()
	{
		menu.removeClass('active');
		menuActive = false;
	}

});