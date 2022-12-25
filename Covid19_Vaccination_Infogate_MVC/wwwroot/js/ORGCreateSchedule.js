$(document).ready(function () {

    // LOAD FRONT END DATA
    menu_title = '<a href="/ORG/CreateSchedule">Tạo lịch tiêm chủng</a>'
    $('#function-navigation-bar-title').html(menu_title)

    homepage = '<a href="/Home">Trang chủ</a>'
    $('#homepage-path').html(homepage)

    subpage = '<a href="/ORG/CreateSchedule">Lịch tiêm</a>'
    $('#subpage-path').html(subpage)

    selected_function = '<a href="/ORG/CreateSchedule">Tạo lịch tiêm chủng</a>'
    $('#selected-function-path').html(selected_function)
    // END LOAD FRONT END DATA

    $('#btn-confirm-create-schedule').click(function () {
        orgid = $('.orgid').attr('id')
        date = $('#schedule-date').val()
        vaccine = $('#vaccine').find('option:selected').val()
        serial = $('#serial').val()
        limitday = $('#limit-day').val()
        limitnoon = $('#limit-noon').val()
        limitnight = $('#limit-night').val()

        if (limitday < 0 || limitnoon < 0 || limitnight < 0) {
            PopupConfirm('Các giá trị giới hạn không thể là số âm!')
            return
        }

        if (limitday == '')
            limitday = 0

        if (limitnoon == '')
            limitnoon = 0

        if (limitnight == '')
            limitnight = 0

        $.ajax({
            cache: false,
            url: '/ORG/CreateSchedule',
            type: 'POST',
            data: { orgid: orgid, date: date, vaccine: vaccine, limitday: limitday, limitnoon: limitnoon, limitnight: limitnight },
            success: function (data) {
                if (data.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(data)
                    return
                }
                PopupConfirm('Tạo lịch tiêm chủng thành công!')
                $('input').val('');
            },
            error: function (error) {
            }
        })
    })
})

var PopupConfirm = function (message) {
    $('.form-message').html(message)
    $('#form-popup-confirm').css('display', 'grid')
    $('#gradient-bg-faded').css('display', 'block')
    $('#form-popup-confirm').find('.btn-confirm').click(function () {
        $('#form-popup-confirm').css('display', 'none')
        $('#gradient-bg-faded').css('display', 'none')
    })
}