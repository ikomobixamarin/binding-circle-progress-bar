using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CustomProgressBar
{
    // typedef NSString * (^StringGenerationBlock)(CGFloat);
    delegate string StringGenerationBlock(nfloat arg0);

    // typedef NSAttributedString * (^AttributedStringGenerationBlock)(CGFloat);
    delegate NSAttributedString AttributedStringGenerationBlock(nfloat arg0);

    // @interface CircleProgressBar : UIView
    [BaseType(typeof(UIView))]
    interface CircleProgressBar
    {
        // @property (nonatomic) CGFloat progressBarWidth;
        [Export("progressBarWidth")]
        nfloat ProgressBarWidth { get; set; }

        // @property (nonatomic) UIColor * progressBarProgressColor;
        [Export("progressBarProgressColor", ArgumentSemantic.Assign)]
        UIColor ProgressBarProgressColor { get; set; }

        // @property (nonatomic) UIColor * progressBarTrackColor;
        [Export("progressBarTrackColor", ArgumentSemantic.Assign)]
        UIColor ProgressBarTrackColor { get; set; }

        // @property (nonatomic) CGFloat startAngle;
        [Export("startAngle")]
        nfloat StartAngle { get; set; }

        // @property (nonatomic) BOOL hintHidden;
        [Export("hintHidden")]
        bool HintHidden { get; set; }

        // @property (nonatomic) CGFloat hintViewSpacing;
        [Export("hintViewSpacing")]
        nfloat HintViewSpacing { get; set; }

        // @property (nonatomic) UIColor * hintViewBackgroundColor;
        [Export("hintViewBackgroundColor", ArgumentSemantic.Assign)]
        UIColor HintViewBackgroundColor { get; set; }

        // @property (nonatomic) UIFont * hintTextFont;
        [Export("hintTextFont", ArgumentSemantic.Assign)]
        UIFont HintTextFont { get; set; }

        // @property (nonatomic) UIColor * hintTextColor;
        [Export("hintTextColor", ArgumentSemantic.Assign)]
        UIColor HintTextColor { get; set; }

        // -(void)setHintTextGenerationBlock:(StringGenerationBlock)generationBlock;
        [Export("setHintTextGenerationBlock:")]
        void SetHintTextGenerationBlock(StringGenerationBlock generationBlock);

        // -(void)setHintAttributedGenerationBlock:(AttributedStringGenerationBlock)generationBlock;
        [Export("setHintAttributedGenerationBlock:")]
        void SetHintAttributedGenerationBlock(AttributedStringGenerationBlock generationBlock);

        // @property (readonly, nonatomic) CGFloat progress;
        [Export("progress")]
        nfloat Progress { get; }

        // @property (readonly, nonatomic) BOOL isAnimating;
        [Export("isAnimating")]
        bool IsAnimating { get; }

        // -(void)setProgress:(CGFloat)progress animated:(BOOL)animated;
        [Export("setProgress:animated:")]
        void SetProgress(nfloat progress, bool animated);

        // -(void)setProgress:(CGFloat)progress animated:(BOOL)animated duration:(CGFloat)duration;
        [Export("setProgress:animated:duration:")]
        void SetProgress(nfloat progress, bool animated, nfloat duration);

        // -(void)stopAnimation;
        [Export("stopAnimation")]
        void StopAnimation();
    }
}
